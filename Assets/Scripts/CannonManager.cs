using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//source https://www.youtube.com/watch?v=xHYmUGyCwQU
public class CannonManager : MonoBehaviour
{
  public GameObject cannonBall;
  public Transform firePoint;
  public LineRenderer lineRenderer;
  public float numberOfChickens = 0;

  private const int N_Trajectory_Points = 10;
  private bool _pressingMouse;
  private Camera _cam;
  private Vector3 _initialVelocity;
  public GameObject _specialBall1;
  public GameObject _specialBall2;
  public GameObject _normalBall;
    // Start is called before the first frame update
    void Start()
    {
    _cam = Camera.main;
    lineRenderer.positionCount = N_Trajectory_Points;
    lineRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetMouseButtonDown(0))
    {
      _pressingMouse = true;
      lineRenderer.enabled = true;
    }
    if (Input.GetMouseButtonUp(0))
    {
      numberOfChickens += 1;
      _pressingMouse = false;
      lineRenderer.enabled = false;
      _Fire();
    }
    if (_pressingMouse) 
    {
      //coordinate transform screen> world
      Vector3 mousePos  = _cam.WorldToScreenPoint(Input.mousePosition);
      mousePos.z = 0f;
      //look at
      transform.LookAt(mousePos);
      _initialVelocity = mousePos - firePoint.position;
      updateLineRender();
    }
    if (Input.GetKeyDown(KeyCode.Alpha1)) 
    {
      cannonBall = _specialBall1;
    }
    if (Input.GetKeyDown(KeyCode.Alpha2)) 
    {
      cannonBall = _specialBall2;
    }
    if (Input.GetKeyDown(KeyCode.Alpha3)) 
    {
      cannonBall = _normalBall;
    }
    }
  private void _Fire() 
  {
    GameObject _cannonBall = Instantiate(cannonBall, firePoint.position, Quaternion.Inverse(Quaternion.identity));

    Rigidbody rb = _cannonBall.GetComponent<Rigidbody>();
    rb.AddForce(_initialVelocity *2, ForceMode.Impulse);
  }
  private void updateLineRender() 
  {
    float g = Physics.gravity.magnitude;
    float velocity = _initialVelocity.magnitude;
    float angle = Mathf.Atan2(_initialVelocity.y, _initialVelocity.x);

    Vector3 start = firePoint.position;

    float timestep = 0.1f;
    float fTime = 0f;
    for (int i = 0; i < N_Trajectory_Points; i++)
    {
      float dx = velocity * fTime * Mathf.Cos(angle);
      float dy = velocity * fTime * Mathf.Sin(angle) - (g * fTime * fTime / 2f);
      Vector3 pos = new Vector3(start.x + dx/500, start.y + dy / 500, 0);
      lineRenderer.SetPosition(i, pos);
      fTime += timestep;
    }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePatrol : MonoBehaviour
{
    [SerializeField] private List<Transform> m_listWaypoints;
    [SerializeField] private float m_distanceThreshold;
    [SerializeField] private float m_speed = 4f;

    private int m_currentWaypointIndex;

    private Transform[] m_waypoints;

    public void Init()
    {
        m_currentWaypointIndex = Random.Range(0, m_listWaypoints.Count);
    }


    private void Update()
    {
        Patrol();
    }

    private void Move(Vector3 p_direction)
    {
        transform.position += p_direction * (m_speed * Time.deltaTime);
    }

    private void Patrol()
    {
        var l_currentWaypoint = m_listWaypoints[m_currentWaypointIndex];
        var l_currDifference = (l_currentWaypoint.position - transform.position);
        var l_direction = l_currDifference.normalized;
        Move(l_direction);
        var l_currDistance = l_currDifference.magnitude;

        if (l_currDistance <= m_distanceThreshold)
        {
            NextWaypoint();
        }

    }

    private void NextWaypoint()
    {
        m_currentWaypointIndex++;
        if (m_currentWaypointIndex > m_listWaypoints.Count - 1)
        {
            m_currentWaypointIndex = 0;
        }
    }

    public void ReceiveWaypoints(Transform[] p_waypoints)
    {
        m_waypoints = p_waypoints;

    }
}

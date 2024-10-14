using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
    private static DropManager instance;
    public static DropManager Instance
    {
        get
        {
            return instance;
        }
    }
    public enum State
    {
        Wait,
        Move,
        Moving,
        MatchCheck,
        HandleMatch,
        Fill
    }
    [SerializeField]
    List<GameObject> dropPrefabs;

    public float moveTime = 5f;
    public int emptyPositionX;
    public int emptyPositionY;
    public State state;


    void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = State.Wait;
        FillTable();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FillTable()
    {
        for (int i = 0; i < 6; ++i)
        {
            for (int j = 0; j < 5; ++j)
            {
                GameObject drop = Instantiate(dropPrefabs[j], gameObject.transform);
                drop.GetComponent<Drop>().Initialize(i, j);
            }
        }
    }

    void StartMove()
    {

    }

    void OneMove()
    {

    }
}

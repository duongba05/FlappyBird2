using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _yPosRange = 0.4f;
    [SerializeField] private GameObject _pipe;
    private float _timer;

    void Start()
    {
        PipeSpawn();
    }

    // Update is called once per frame

    private void PipeSpawn()
    {
        Vector3 pipePos = transform.position+new Vector3(0,Random.Range(-_yPosRange,_yPosRange));// cụ thể chưa hiểu rõ 
        GameObject pipe = Instantiate(_pipe, pipePos, Quaternion.identity);
        Destroy(pipe,10f);
    }
    void Update()
    {
        if (_timer > _maxTime) 
        {
            PipeSpawn();
            _timer = 0;
        }    
        _timer += Time.deltaTime;
    }
}

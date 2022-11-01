using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    ParticleSystem p;
    float size = 2f;
    int count = 1500;
    void Start()
    {
        p = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // 粒子的大小逐渐变小
        size = size * 0.999f;
        // 最大粒子量逐渐减少
        count = count - 1;
        var main = p.main;
        main.startSize = size;
        main.maxParticles = count;
    }
}

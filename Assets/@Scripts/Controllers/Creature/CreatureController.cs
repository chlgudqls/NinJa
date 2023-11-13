using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;


public class CreatureController : BaseController
{
    public Rigidbody2D _rigidBody { get; set; }

    void Awake()
    {
        
    }
    Define.CreatureState _creatureState = Define.CreatureState.Moving;

    public virtual Define.CreatureState CreatureState
    {
        get { return _creatureState; }
        set
        {
            _creatureState = value;
            //UpdateAnimation();
        }
    }
    public override bool Init()
    {
        base.Init();

        return true;
    }


    public virtual void OnDead()
    {
        _rigidBody.simulated = false;
        transform.localScale = new Vector3(1, 1, 1);
        CreatureState = CreatureState.Dead;
    }
}

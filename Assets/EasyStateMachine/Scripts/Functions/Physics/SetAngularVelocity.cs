﻿//-----------------------------------------------------------------------
// <copyright file="SetAngularVelocity.cs" company="https://github.com/marked-one/EasyStateMachine">
//     Copyright © 2014-2015 Vladimir Klubkov. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace EasyStateMachine.Functions.Physics
{
    using UnityEngine;

    /// Sets the angular velocity to Rigidbody.
    [AddComponentMenu("Easy State Machine/Functions/Physics/Set Angular Velocity")]
    public sealed class SetAngularVelocity : Function
    {
        [Header("Set"),]
        [SerializeField]
        bool global = false;

        [SerializeField]
        string vector3 = null;

        [Header("as angular velocity")]
        [SerializeField]
        Rigidbody to = null;

#pragma warning disable 0414
        [Space(8)]
        [SerializeField]
        [Tooltip("Choose where the job should be done.")]
        In @in = In.FixedUpdate;
#pragma warning restore 0414

        void Do()
        {
            Vector3 velocity;
            if (TryGet(global, vector3, out velocity, Vector3.zero))
                to.angularVelocity = velocity;
        }
    }
}

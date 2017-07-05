﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NumberObject.cs" company="Slash Games">
//   Copyright (c) Slash Games. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Slash.Unity.DataBind.Foundation.Providers.Objects
{
    using System;

    using Slash.Unity.DataBind.Core.Presentation;

    using UnityEngine;

    /// <summary>
    ///   Provides a plain number object.
    ///   <para>Output: Number.</para>
    /// </summary>
    [AddComponentMenu("Data Bind/Foundation/Objects/[DB] Number Object")]
    public class NumberObject : DataProvider
    {
        #region Fields

        [Tooltip("Number this provider holds.")]
        public float Number;

        private float currentNumber;

        #endregion

        #region Properties

        public override object Value
        {
            get
            {
                return this.Number;
            }
        }

        #endregion

        #region Methods

        protected override void UpdateValue()
        {
            this.currentNumber = this.Number;
            this.OnValueChanged(this.Number);
        }
        
        protected void Update()
        {
            if (Math.Abs(this.currentNumber - this.Number) > 0.001f)
            {
                this.UpdateValue();
            }
        }

        #endregion
         
    }
}
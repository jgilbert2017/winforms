﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

namespace System.Windows.Forms;

[AttributeUsage(AttributeTargets.All)]
internal sealed class SRDescriptionAttribute : DescriptionAttribute
{
    private bool replaced;

    public SRDescriptionAttribute(string description)
        : base(description)
    {
    }

    public override string Description
    {
        get
        {
            if (!replaced)
            {
                replaced = true;
                DescriptionValue = SR.GetResourceString(base.Description);
            }

            return base.Description;
        }
    }
}

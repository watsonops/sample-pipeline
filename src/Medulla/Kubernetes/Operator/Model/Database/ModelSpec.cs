﻿// Licensed to the Medulla Contributors under one or more agreements.
// The Medulla Contributors licenses this file to you under the Apache 2.0 license.
// See the LICENSE file in the project root for more information.

using KubeOps.Operator.Entities.Annotations;

namespace Medulla.Kubernetes.Operator.Model.Database;

/// <summary>
/// Spec of CRD for model/table within Database
/// </summary>
public struct ModelSpec
{
    /// <summary>
    /// ModelSpec constructor
    /// </summary>
    public ModelSpec() { }
    /// <summary>
    /// Name is an element of ModelSpec which is the name of the model/table
    /// </summary>
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Columns is an element of ModelSpec which contains a list of ColumnSpec of the model/table
    /// </summary>
    [Required]
    public List<ColumnSpec> Columns { get; set; } = new List<ColumnSpec>();
}

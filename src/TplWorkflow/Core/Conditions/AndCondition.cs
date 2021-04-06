﻿// Copyright (c) Microsoft Corporation.// Licensed under the MIT license.
namespace TplWorkflow.Core.Conditions
{
  using TplWorkflow.Core.Common;
  using TplWorkflow.Core.Common.Interfaces;
  using TplWorkflow.Extensions;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  public class AndCondition : Condition, IMultiCondition
  {
    public IList<Condition> Conditions { get; }

    public AndCondition(IList<Condition> conditions)
    {
      Conditions = conditions;
    }

    public override async Task<AsyncResult<bool>> Resolve(ExecutionContext context)
    {
      var evaluated = !(await this.Evaluate(context)).Contains(false);
      return new AsyncResult<bool>(evaluated);
    }
  }
}

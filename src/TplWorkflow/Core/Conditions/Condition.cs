﻿using TplWorkflow.Core.Common;
using System.Threading.Tasks;

namespace TplWorkflow.Core.Conditions
{
  public abstract class Condition
  {
    public abstract Task<AsyncResult<bool>> Resolve(ExecutionContext context);
  }
}
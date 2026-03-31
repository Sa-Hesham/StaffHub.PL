using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHub.PLL.RespnseResult;

public record class ResponseResult<T>(T? Result, string? Errormessage, bool IsHasErrorOrNo);

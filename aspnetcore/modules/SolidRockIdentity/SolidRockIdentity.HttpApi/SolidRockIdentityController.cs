using Dedsi.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace SolidRockIdentity;

[ApiController]
[Area(SolidRockIdentityDomainOptions.ApplicationName)]
[Route("api/SolidRockIdentity/[controller]/[action]")]
public abstract class SolidRockIdentityController : DedsiControllerBase
{
    
}
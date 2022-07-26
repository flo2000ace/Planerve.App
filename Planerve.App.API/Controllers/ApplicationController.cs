﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Copy;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Create;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Delete;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationList;

namespace Planerve.App.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ApplicationController : Controller
{
    private readonly IMediator _mediator;

    public ApplicationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("Get/{id:guid}", Name = "GetApplicationById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<ApplicationDetailVm>> GetById(Guid id)
    {
        var applicationQuery = new GetApplicationDetailQuery { Id = id };
        return Ok(await _mediator.Send(applicationQuery));
    }
    [HttpGet("List", Name = "GetApplicationList")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<List<ApplicationListVm>>> ListAll()
    {
        var applicationListToGet = new GetApplicationListQuery();

        var dtos = await _mediator.Send(applicationListToGet);
        return Ok(dtos);
    }

    [HttpPost("Create", Name = "CreateApplication")]
    public async Task<ActionResult<Guid>> Create([FromBody] CreateApplicationCommand createAppDataCommand)
    {
        var id = await _mediator.Send(createAppDataCommand);

        return Ok(id);
    }

    [HttpPost("Copy", Name = "CopyApplication")]
    public async Task<ActionResult<Guid>> Copy([FromBody] CopyApplicationCommand copyAppDataCommand)
    {
        var id = await _mediator.Send(copyAppDataCommand);

        return Ok(id);
    }

    [HttpDelete("Delete/{id:guid}", Name = "DeleteApplication")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleteAppDataCommand = new DeleteApplicationCommand { Id = id };
        await _mediator.Send(deleteAppDataCommand);
        return NoContent();
    }
}
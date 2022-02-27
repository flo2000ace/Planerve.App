﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planerve.API.Utility;
using Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;
using Planerve.App.Core.Features.ApplicationData.Commands.DeleteApplication;
using Planerve.App.Core.Features.ApplicationData.Queries.DownloadApplicationById;
using Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationById;
using Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationList;

namespace Planerve.App.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicationController : Controller
{
    private readonly IMediator _mediator;

    public ApplicationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("Get/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<ApplicationDetailVm>> GetApplicationById(Guid id)
    {
        var applicationQuery = new GetApplicationDetailQuery { Id = id };
        return Ok(await _mediator.Send(applicationQuery));
    }

    [HttpGet(Name = "GetApplicationList")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<List<ApplicationListVm>>> GetAllApplications()
    {
        string LoggedInUser = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;

        LoggedInUser = "nigga";

        var applicationListToGet = new GetApplicationListQuery { UserId = LoggedInUser };

        var dtos = await _mediator.Send(applicationListToGet);
        return Ok(dtos);
    }

    [HttpPost("Create")]
    public async Task<ActionResult<Guid>> CreateApplication([FromBody] CreateApplicationCommand createAppDataCommand)
    {
        var UserId = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
        createAppDataCommand.OwnerId = UserId;

        var id = await _mediator.Send(createAppDataCommand);

        return Ok(id);
    }

    [HttpDelete("Delete/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> DeleteApplication(Guid id)
    {
        var deleteAppDataCommand = new DeleteApplicationCommand { ApplicationId = id };
        await _mediator.Send(deleteAppDataCommand);
        return NoContent();
    }
    [FileResultContentType("application/pdf")]
    [HttpGet("Download/{id:guid}")]
    public async Task<FileResult> DownloadApplication(Guid id)
    {
        var applicationToDownload = new GetApplicationDownloadQuery { Id = id };
        var downloadDto = await _mediator.Send(applicationToDownload);

        return File(downloadDto.Data.Result, downloadDto.ContentType, downloadDto.ApplicationExportFileName);
    }
}
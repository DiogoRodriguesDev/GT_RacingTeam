﻿using MediatR;

namespace GT_RT_BackEnd.Commands
{
    public record DeletePilotoCommand(int id) : IRequest;
}

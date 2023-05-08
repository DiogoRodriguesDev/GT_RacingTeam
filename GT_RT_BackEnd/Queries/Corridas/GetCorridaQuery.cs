﻿using ClassLibrary_GT_RT.Requests;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Queries.Corridas
{
    public record GetCorridaQuery(CorridaRequest CorridaRequest) : IRequest<Corrida>;
}

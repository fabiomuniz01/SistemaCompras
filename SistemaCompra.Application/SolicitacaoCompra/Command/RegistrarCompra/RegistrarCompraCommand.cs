﻿using System;
using MediatR;

namespace SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra
{
    public class RegistrarCompraCommand : IRequest<bool>
    {
        public string UsuarioSolicitante { get; private set; }
        public string NomeFornecedor { get; private set; }
        public DateTime Data { get; private set; }
        public decimal TotalGeral { get; private set; }
        public int Situacao { get; private set; }
        public int CondicaoPagamento { get; private set; }
    }
}

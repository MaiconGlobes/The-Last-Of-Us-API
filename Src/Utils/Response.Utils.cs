﻿using System;
using System.Collections.Generic;

namespace API_REST_The_Last_Of_Us.Src.Utils
{
    public class ResponseUtils
    {
        private static ResponseUtils FInstancia { get; set; }
        private object FObjRetorno { get; set; }

        public static ResponseUtils Instancia()
        {
            FInstancia ??= new ResponseUtils();
            return FInstancia;
        }

        internal virtual object RetornoBoasVindasOk()
        {
            FObjRetorno = new
            {
                mensagem = "Não importa o que aconteça, você continua encontrando algo pelo qual lutar. Ellie"
            };

            return FObjRetorno;
        }

        internal virtual Object RetornoOk(Object ADados)
        {
            FObjRetorno = new
            {
                retorno = new
                {
                    status = "Sucesso",
                    codigo_status = 1,
                    dados = ADados
                }
            };

            return FObjRetorno;
        }

        internal virtual object RetornoOk<T>(List<T> ADados)
        {
            FObjRetorno = new
            {
                retorno = new
                {
                    status = "Sucesso",
                    codigo_status = 1,
                    dados = ADados
                }
            };

            return FObjRetorno;
        }
    }
}

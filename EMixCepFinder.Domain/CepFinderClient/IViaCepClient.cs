﻿using EMixCepFinder.Domain.Dto;
using EMixCepFinder.Domain.Model;
using Refit;

namespace EMixCepFinder.Domain.CepFinderClient
{
    public interface IViaCepClient
    {
        /// <summary>
        /// Retrieves the address information from the ViaCep API based on the given CEP code.
        /// </summary>
        /// <param name="cep">The CEP code to retrieve information for.</param>
        /// <returns>An <see cref="AddressInfo"/> object containing the address information.</returns>
        [Get("/ws/{cep}/json/")]
        Task<AddressInfoDto> GetAddressInfoAsync(string cep);
    }
}
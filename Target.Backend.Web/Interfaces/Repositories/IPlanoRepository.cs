﻿using System.Threading.Tasks;
using Target.Backend.Web.Models;

namespace Target.Backend.Web.Interfaces.Repositories
{
    public interface IPlanoRepository
    {
        /// <summary>
        /// Obtem plano pelo id
        /// </summary>
        /// <param name="id">id do plano</param>
        /// <returns>objeto do tipo Plano</returns>
        public Task<Plano> GetPlanoByID(int id);
    }
}

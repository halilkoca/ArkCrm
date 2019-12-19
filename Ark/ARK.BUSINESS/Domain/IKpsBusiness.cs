﻿using ARK.CORE.Response;
using ARK.MODEL.V1.Integration.KPSPublicV1;
using ARK.MODEL.V1.Integration.KPSPublicV2;
using ARK.MODEL.V1.Integration.KPSPublicYabanciDogrula;
using System.Threading.Tasks;

namespace ARK.BUSINESS.Domain
{
    public interface IKpsBusiness : IBusiness
    {
        Task<ServiceResponse<bool>> TCKimlikNoDogrulaAsync(TCKimlikNoDogrulaRequestModel request);
        Task<ServiceResponse<bool>> KisiVeCuzdanDogrulaAsync(KisiVeCuzdanDogrulaRequestModel request);
        Task<ServiceResponse<bool>> YabanciKimlikNoDogrulaAsync(YabanciKimlikNoDogrulaRequestModel request);
    }
}

using DAWM_Backend_API.DataLayer.Models;
using DAWM_Backend_API.DataLayer.Dtos;

namespace DAWM_Backend_API.DataLayer.Mapping
{
    public static class MakerMappingExtensions
    {
        public static MakerDto ToMakerDto(this Maker maker)
        {
            if (maker == null)
                return null;

            var returned = new MakerDto();
            returned.Name = maker.Name;
            returned.Country = maker.Country;
            returned.Id = maker.Id;

            return returned;
        }
    }
}

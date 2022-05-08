using Marvel_Api_Wrapper.Entities;
using Marvel_Api_Wrapper.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Marvel_Api_Wrapper.Managers
{
    public class CharacterManager : ICharacterManager
    {
        public async Task<MarvelApiResponse<Characters>> GetCharacters()
        {
            var url = MarvelUrls.Characters();

            using (var response = await ApiHelper.GetAsync(url))
            {
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();

                var json= JsonSerializer.Deserialize<MarvelApiResponse<Characters>>(result);

                return json;
            }
            return new MarvelApiResponse<Characters>(); ;
        }
    }
}

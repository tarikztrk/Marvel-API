using Marvel_Api_Wrapper.Entities;

namespace Marvel_Api_Wrapper.Managers
{
    public interface ICharacterManager
    {
        Task<MarvelApiResponse<Characters>> GetCharacters();
    }
}
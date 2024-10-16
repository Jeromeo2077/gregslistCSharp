namespace gregslistCSharp.Services;

public class HousesService

public HousesService(HousesRepository housesRepository)
{
  _housesRepository = housesRepository;
}

private readonly HousesRepository _housesRepository;
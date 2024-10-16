namespace gregslistCSharp.Repositories
{
  public class HousesRepository
  {

    public HousesRepository(IDbConnection db)
    {
      _db = db;
    }

    private readonly IDbConnection _db;


  }
}
namespace RestWithASPNETUdemy.Services;
using RestWithASPNETUdemy.Model;

    public interface IPersonService
    {

        Person Create(Person person);
        Person FindBYID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);


    }


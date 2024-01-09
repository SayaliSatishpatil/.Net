using BOL;

namespace SAL;
public interface IEmployeeService{
    public List<Employee> GetAll();
    public Employee GetById(int id);
    public void Insert(Employee emp);
     public void Update(Employee emp);
     public void Delete(int id);
}
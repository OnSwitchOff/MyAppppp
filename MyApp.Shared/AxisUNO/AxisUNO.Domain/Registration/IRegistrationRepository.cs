namespace  MyApp.Domain.Registration;

public interface IRegistrationRepository
{
    Task<Registration> GetRegistrationAsync();

    Task UpdateRegistrationAsync(Registration registration);
}
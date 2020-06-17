using System;
using System.Threading.Tasks;

namespace Crispy_Waddle_Console.Application
{
    public interface IContentsDisplayHandler
    {
        Task DisplayPhotosAsync(string albumNumber);
    }
}

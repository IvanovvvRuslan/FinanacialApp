using Task11_Common.ViewModels;

namespace Task11_BlazorApp.Services
{
    public interface IOperationTypeService
    {
        Task<IEnumerable<OperationTypeViewModelCommon>> GetOperationTypes();
        Task<OperationTypeViewModelCommon> GetOperationTypeById(int id);
        Task<string> CreateOperationType(OperationTypeViewModelCommon operationTypeDto);
        Task<string> UpdateOperationType(int id, OperationTypeViewModelCommon operationTypeDto);
        Task<string> DeleteOperationType(int id);
    }

    public class OperationTypeService : IOperationTypeService
    {
        private readonly HttpClient _httpClient;

        public OperationTypeService(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient("API");
        }

        public async Task<IEnumerable<OperationTypeViewModelCommon>> GetOperationTypes()
        {
            var operationTypes = await _httpClient.GetFromJsonAsync<IEnumerable<OperationTypeViewModelCommon>>("operationtype");

            return operationTypes;
        }

        public async Task<OperationTypeViewModelCommon> GetOperationTypeById(int id)
        {
            var operationType = await _httpClient.GetFromJsonAsync<OperationTypeViewModelCommon>($"operationtype/{id}");

            return operationType;
        }

        public async Task<string> CreateOperationType(OperationTypeViewModelCommon operationTypeDto)
        {
            string response;

            HttpResponseMessage responseContent = await _httpClient.PostAsJsonAsync("/operationtype", operationTypeDto);
            response = await responseContent.Content.ReadAsStringAsync();

            return response;
        }

        public async Task<string> UpdateOperationType(int id, OperationTypeViewModelCommon operationTypeDto)
        {
            string response;

            HttpResponseMessage responseContent = await _httpClient.PutAsJsonAsync($"operationtype/{id}", operationTypeDto);
            response = await responseContent.Content.ReadAsStringAsync();
            
            return response;
        }

        public async Task<string> DeleteOperationType(int id)
        {
            string response;
            try
            {
                HttpResponseMessage responseContent = await _httpClient.DeleteAsync($"operationtype/{id}");
                response = await responseContent.Content.ReadAsStringAsync();

                Console.WriteLine(responseContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                response = ex.Message;
            }
            return response;
        }
    }
}

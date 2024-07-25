using Task11_Common.ViewModels;

namespace Task11_BlazorApp.Services
{
    public interface IFinancialOperationService
    {
        Task<IEnumerable<FinancialOperationViewModelCommon>> GetFinancialOperations();
        Task<FinancialOperationViewModelCommon> GetFinancialOperationById(int id);
        Task<string> CreateFinancialOperation(FinancialOperationViewModelCommon financialOperationDto);
        Task<string> UpdateFinancialOperation(int id, FinancialOperationViewModelCommon financialOperationDto);
        Task<string> DeleteFinancialOperation(int id);
    }

    public class FinancialOperationService : IFinancialOperationService
    {
        private readonly HttpClient _httpClient;

        public FinancialOperationService(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient("API");
        }

        public async Task<IEnumerable<FinancialOperationViewModelCommon>> GetFinancialOperations()
        {
            var financialOperations = await _httpClient.GetFromJsonAsync<IEnumerable<FinancialOperationViewModelCommon>>("financialoperation");

            return financialOperations;
        }

        public async Task<FinancialOperationViewModelCommon> GetFinancialOperationById(int id)
        {
            var financialOperation = await _httpClient.GetFromJsonAsync<FinancialOperationViewModelCommon>($"financialoperation/{id}");

            return financialOperation;
        }

        public async Task<string> CreateFinancialOperation(FinancialOperationViewModelCommon financialOperationDto)
        {
            string response;

            HttpResponseMessage responseContent = await _httpClient.PostAsJsonAsync("/financialoperation", financialOperationDto);
            response = await responseContent.Content.ReadAsStringAsync();

            return response;
        }

        public async Task<string> UpdateFinancialOperation(int id, FinancialOperationViewModelCommon financialOperationDto)
        {
            string response;

            HttpResponseMessage responseContent = await _httpClient.PutAsJsonAsync($"/financialoperation/{id}", financialOperationDto);
            response = await responseContent.Content.ReadAsStringAsync();

            return response;
        }

        public async Task<string> DeleteFinancialOperation(int id)
        {
            string response;

            try
            {
                HttpResponseMessage responseContent = await _httpClient.DeleteAsync($"/financialoperation/{id}");
                response = await responseContent.Content.ReadAsStringAsync();
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

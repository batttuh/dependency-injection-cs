using Platform.Services;
	namespace Platform {
		public class WeatherEndpointAdapter {
		public static async Task Endpoint(HttpContext context,
		IResponseFormatter formatter) {
			await formatter.Format(context, "Endpoint Class: It is cloudy in Milan (Adapter Class)");
		}
	}
}
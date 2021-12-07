# todoApi-dotnet6
ASP.NET Core minimal web APIs

Minimal APIs are architected to create HTTP APIs with minimal dependencies. They are ideal for microservices and apps that want to include only the minimum files, features, and dependencies in ASP.NET Core.

Differences between minimal APIs and APIs with controllers

    No support for filters: For example, no support for IAsyncAuthorizationFilter, IAsyncActionFilter, IAsyncExceptionFilter, IAsyncResultFilter, and IAsyncResourceFilter.
    No support for model binding, i.e. IModelBinderProvider, IModelBinder. Support can be added with a custom binding shim.
    No support for binding from forms. This includes binding IFormFile. We plan to add support for IFormFile in the future.
    No built-in support for validation, i.e. IModelValidator
    No support for application parts or the application model. There's no way to apply or build your own conventions.
    No built-in view rendering support. We recommend using Razor Pages for rendering views.
    No support for JsonPatch
    No support for OData
    No support for ApiVersioning. See this issue for more details.

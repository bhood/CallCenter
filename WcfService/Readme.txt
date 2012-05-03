USER INTERFACE
- Platform is MVC3 using the Razor view engine.
- The invoice Guid will be passed as a parameter in the URL querystring.
- Develop a thin model based on the WfcService.Invoice class. Use it to lazy load data.
- User authentication happens outside of the invoice page and is not a concern.
- The page should use the full width of the screen and use jQuery ThemeRoller for overall style.
- Use jQuery UI for tabs, dialogs, and validation
- Any style sheets and scripts should be implemented in external files.
- The icon images will be provided.
- Refer to the latest version at https://www.lucidchart.com/documents#docs?folder_id=1270933&browser=icon&sort=saved-desc&event_client=201205021530594fa1a793-2704-4888-b896-513a0a56df9a for a mockup of screens.
- Add the WcfService as a Service Reference to your MVC project to consume it.
- The Close button redirects to the URL provided by InvoiceService.GetReturnUrl
- Use Datalist.net for all display lists.
- Call InvoiceService.Getreview the first time the Review tab is shown. Refresh it if any payments or services have been added since the last focus.
- Implement the Add Note function as a popup dialog. Move the button down to the bottom so that it is accessible on all tabs.
- Pop up the warning if Severity = 3.

WCFSERVICE FILES
- IInvoiceService		The invoice service interface
- InvoiceService		The invoice service implementation
- InvoiceDataContracts	The data contracts (objects) used by the invoice service.
// See https://aka.ms/new-console-template for more information

using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;

QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

//Document.Create(container =>
//{
//    container.Page(page =>
//    {
//        page.Size(PageSizes.A4);

//        page.Margin(1,
//            QuestPDF.Infrastructure.Unit.Centimetre);

//        page.Header().Text("Hello world!")
//        .Bold().FontSize(35)
//        .FontColor(Colors.Red.Medium);

//    });
//}).GeneratePdf("hello world.pdf");

Document.Create(container =>
{
    container.Page(page =>
    {
        page.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);

        page.Header().Text("Let's learn .NET")
        .Bold().FontSize(35).FontColor(Colors.Blue.Medium);

        page.Content().Column(column =>
        {
            column.Spacing(20);

            column.Item().Text(Placeholders.LoremIpsum());
            column.Item().Image(Placeholders.Image(200, 100));

            column.Item().Row(row =>
            {
                row.Spacing(20);

                row.RelativeItem().Column(c =>
                {
                    c.Item().Text(Placeholders.LoremIpsum());
                    c.Item().Image(Placeholders.Image(200, 100));
                });

                row.RelativeItem().Column(c =>
                {
                    c.Item().Text(Placeholders.LoremIpsum());
                    c.Item().Image(Placeholders.Image(200, 100));
                });
            });

            column.Item().Row(row =>
            {
                row.Spacing(20);

                row.RelativeItem().Column(c =>
                {
                    c.Item().Text(Placeholders.LoremIpsum());
                    c.Item().Image(Placeholders.Image(200, 100));
                });

                row.RelativeItem().Column(c =>
                {
                    c.Item().Text(Placeholders.LoremIpsum());
                    c.Item().Image(Placeholders.Image(200, 100));
                });

                row.RelativeItem().Column(c =>
                {
                    c.Item().Text(Placeholders.LoremIpsum());
                    c.Item().Image(Placeholders.Image(200, 100));
                });
            });
        });

        page.Footer().AlignCenter().Text(x =>
        {
            x.CurrentPageNumber();
            x.Span(" / ");
            x.TotalPages();
        });

    });
}).ShowInPreviewer();

Console.WriteLine("Hello, World!");

$('[data-toggle="tooltip"]').tooltip();
// отмена для ссылок с атрибутом data-trigger="click" стандартного поведения
$('a[data-trigger="hover"]').click(function (e) {
    e.preventDefault();
});
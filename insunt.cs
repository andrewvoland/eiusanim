public static class MyExtensionMethods {
    public static bool IsValidUrl(this string text) {
        Regex rx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        return rx.IsMatch(text);
    }
}

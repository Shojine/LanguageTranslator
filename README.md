# Language Translator 

Current Design Patterns
- **Adapter Pattern:** Each translation provider has its own incompatible API. The adapter pattern wraps each provider in a class implementing a common ITranslationService interface, so the rest of the app depends only on that interface and never on a specific provider. This lets us swap translators by changing a single line in Config.Initialize(). The provider is currently configured to Google Translate with a limited number of tokens.
- **Singleton Pattern:** Only one instance of AppConfig should ever be running at a time. After implementation Program.cs now calls the instance rather than creating an instance each time the program is ran.
- **Facade Pattern:** TranslatorFacade gives the menu one simple entry point (Translate) that hides the multi-step translation work, this reads and validates input, choosing auto-detect or an explicit source/target, and calling the right Translator method.

# Language Translator 

Current Design Patterns
- Adapter Pattern: Each translation provider has its own incompatible API. The adapter pattern wraps each provider in a class implementing a common ITranslationService interface, so the rest of the app depends only on that interface and never on a specific provider. This lets us swap translators by changing a single line in Config.Initialize(). The provider is currently configured to Google Translate with a limited number of tokens.

namespace NatureAPI;

public class Prompts
{
    public static string GeneratePlacesPrompt(string jsonData)
    {
        return @$"
        Eres un analista experto en naturaleza, ecoturismo y rutas ecológicas.
        Analiza la siguiente información de lugares, senderos, amenidades y coordenadas (formato JSON):
        {jsonData}

        Debes responder **EXCLUSIVAMENTE** en formato JSON con la siguiente estructura:

        {{
            ""topPlace"": {{
                ""name"": string,
                ""reason"": string
            }},
            ""topTrail"": {{
                ""name"": string,
                ""difficulty"": string,
                ""distanceKm"": double
            }},
            ""accessibilityReport"": {{
                ""totalAccessible"": int,
                ""percentageAccessible"": double
            }},
            ""categorySummary"": [
                {{
                    ""category"": string,
                    ""count"": int
                }}
            ],
            ""patterns"": [string]
        }}

        En el apartado ""patterns"", incluye observaciones relevantes como:
        - Lugares más populares
        - Categorías dominantes
        - Tendencias de dificultad de senderos
        - Lugares más accesibles
        - Insights interesantes sobre rutas o amenidades

        Si no puedes generar una respuesta válida, responde SOLO con: error.
        No agregues saludos, explicaciones o texto extra.
        ";
    }
}

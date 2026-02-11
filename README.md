# Unity AI Project

Prototipo en Unity para una escena de presentación de personaje con controles UI (rotación, zoom y ajuste de cámara), ambientación con VFX y audio, y generación de assets con herramientas de IA de Unity.

## Versión de Unity utilizada

- **Unity Editor:** `6000.2.6f2`.

## Paquetes externos / dependencias relevantes

Además de módulos base de Unity, este proyecto integra:

- **Unity AI Assistant** (`com.unity.ai.assistant`)
- **Unity AI Generators** (`com.unity.ai.generators`)
- **Unity AI Inference** (`com.unity.ai.inference`)
- **Unity Input System** (`com.unity.inputsystem`)
- **Universal Render Pipeline (URP)** (`com.unity.render-pipelines.universal`)

### Assets de terceros en el proyecto

- **Ultimate Loot VFX Pack ⚜️ 175 Effects** (Piloto Studio), importado dentro de `Assets/Piloto Studio`.

## Flujo asistido por IA seguido en el proyecto

El proyecto refleja un flujo de creación asistida por IA en Unity:

1. **Asistencia durante scripting**: varios scripts de control incluyen marca `AI-Tag` indicando creación con ayuda de Assistant.
2. **Generación de recursos visuales**: en `GeneratedAssets/` hay metadatos con prompts y modelos como *UI Frame Generator* para iconos/UI.
3. **Generación de audio**: también hay metadatos de generación con modelo *Text to Sound* para efectos sonoros.
4. **Integración en escena**: los recursos generados y los scripts se conectan en la escena principal para una demo interactiva de selección/presentación de personaje.

## Escena principal

- `Assets/Scenes/Unity AI Proto.unity`

## Objetivo del repositorio

Servir como base/prototipo para experimentar un pipeline de contenido en Unity que combina:

- interacción de personaje por UI,
- VFX de paquete externo,
- y creación de recursos con herramientas de IA.

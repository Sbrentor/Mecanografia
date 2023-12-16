using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECANOGRAFIA.mecanografia.DESAFIOS
{
    public partial class FrmTematicasV : Form
    {
        clases.helpers h = new clases.helpers();
        clases.db DB = new clases.db();
        int correctas, pcompletadas, incorrectas, L_omitidas = 0, L_PosM = 0, L_added = 0, i, j;
        string p, p_escrita;

        public FrmTematicasV()
        {
            InitializeComponent();
        }

        private void LetterAddedWrongly()
        {
            List<string> palabras = new List<string>(txtpalabrasmostradas.Text.Trim().Split(' '));
            p = palabras.Count > 0 ? palabras[0] : string.Empty;

            List<string> palabras_escritas = new List<string>(txtpalabrasescritas.Text.Trim().Split(' '));
            p_escrita = palabras_escritas.Count > 0 ? palabras_escritas[0] : string.Empty;

            i = p.Length;
            j = p_escrita.Length;

            while (j > i) { L_added++; j--; }
        }

        private int WrongLetterPosition()
        {
            string[] textshowed = txtpalabrasmostradas.Text.Split();
            string[] TextTyped = txtpalabrasescritas.Text.Split();

            int minLength = Math.Min(textshowed.Length, TextTyped.Length);

            for (i = 0; i < minLength; i++)
            {
                p = textshowed[i];
                p_escrita = TextTyped[i];

                for (j = 0; j < Math.Min(p.Length, p_escrita.Length); j++) { if (p[j] != p_escrita[j]) { L_PosM++; } }
            }
            return L_PosM;
        }

        private void SkippedLetters()
        {
            List<string> palabras = new List<string>(txtpalabrasmostradas.Text.Trim().Split(' '));
            p = palabras.Count > 0 ? palabras[0] : string.Empty;

            List<string> palabras_escritas = new List<string>(txtpalabrasescritas.Text.Trim().Split(' '));
            p_escrita = palabras_escritas.Count > 0 ? palabras_escritas[0] : string.Empty;

            i = p.Length;
            j = p_escrita.Length;

            while (i > j) { L_omitidas++; i--; }
        }

        private void listar_palabras(string tematica = "",int random = 0)
        {
            int i, j; string temp; Random randomwords = new Random();
            if (tematica == "Ciencia y Tecnología")
            {
                string[] CT = {"La", "ciencia", "y", "la", "tecnología", "avanzan", "a", "pasos", "agigantados,", "transformando", "nuestro", "mundo", "de", "maneras", "sorprendentes.",    "Uno", "de", "los", "campos", "más", "emocionantes", "es", "la", "inteligencia", "artificial", "(IA)", "y", "el", "aprendizaje", "automático.",    "Estas", "disciplinas", "permiten", "a", "las", "máquinas", "aprender", "y", "mejorar", "su", "rendimiento", "sin", "intervención", "humana", "directa.",    "Desde", "asistentes", "virtuales", "hasta", "diagnósticos", "médicos", "más", "precisos,", "la", "IA", "está", "revolucionando", "diversas", "industrias.",   "En", "el", "ámbito", "de", "la", "medicina,", "la", "biotecnología", "ha", "experimentado", "avances", "notables.", "Terapias", "génicas,", "edición", "de", "genes",    "y", "tratamientos", "personalizados", "son", "cada", "vez", "más", "accesibles.", "Estos", "desarrollos", "ofrecen", "esperanzas", "para", "enfermedades", "genéticas",    "antes", "consideradas", "incurables.", "Además,", "la", "nanotecnología,", "que", "implica", "manipular", "estructuras", "a", "escala", "nanométrica,", "está", "abriendo",    "nuevas", "posibilidades", "en", "medicina,", "desde", "la", "administración", "precisa", "de", "medicamentos", "hasta", "la", "detección", "temprana", "de", "enfermedades.",    "La", "sostenibilidad", "y", "las", "energías", "renovables", "son", "áreas", "cruciales", "en", "la", "intersección", "de", "ciencia", "y", "tecnología.", "Innovaciones",    "en", "paneles", "solares,", "almacenamiento", "de", "energía", "y", "tecnologías", "eólicas", "están", "transformando", "la", "matriz", "energética", "global.", "La",    "necesidad", "de", "abordar", "el", "cambio", "climático", "ha", "impulsado", "investigaciones", "para", "crear", "soluciones", "más", "ecológicas", "y", "eficientes.",    "En", "el", "ámbito", "tecnológico,", "la", "computación", "cuántica", "es", "una", "frontera", "fascinante.", "A", "diferencia", "de", "la", "computación", "clásica,",    "que", "utiliza", "bits,", "la", "computación", "cuántica", "emplea", "qubits,", "aprovechando", "principios", "de", "la", "mecánica", "cuántica.", "Esto", "podría",    "revolucionar", "la", "capacidad", "de", "procesamiento", "de", "la", "información,", "afectando", "áreas", "como", "la", "criptografía", "y", "la", "simulación", "molecular.",    "Asimismo,", "la", "realidad", "virtual", "(RV)", "y", "aumentada", "(RA)", "están", "transformando", "la", "forma", "en", "que", "interactuamos", "con", "el", "entorno", "digital.",    "Desde", "aplicaciones", "educativas", "inmersivas", "hasta", "experiencias", "de", "compra", "más", "personalizadas,", "estas", "tecnologías", "están", "creando", "un", "puente",    "entre", "el", "mundo", "virtual", "y", "el", "real.",    "En", "conclusión,", "la", "ciencia", "y", "la", "tecnología", "están", "dando", "forma", "a", "un", "futuro", "emocionante.", "Estos", "avances", "no", "solo", "mejoran",    "nuestras", "vidas", "cotidianas,", "sino", "que", "también", "plantean", "preguntas", "éticas", "y", "sociales", "importantes", "que", "la", "sociedad", "deberá", "abordar",    "en", "los", "próximos", "años."};

                if (random > 0) {
                    for (i = CT.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = CT[i];
                        CT[i] = CT[j];
                        CT[j] = temp;
                    } 
                }
                txtpalabrasmostradas.Text = string.Join(" ", CT);
            }
            else if (tematica == "Cultura y Entretenimiento")
            {
                string[] CE = {"La", "cultura", "y", "el", "entretenimiento", "son", "parte", "integral", "de", "nuestra", "vida", "cotidiana.", "Desde", "tendencias", "en", "cine,", "música,", "literatura",    "y", "arte", "hasta", "el", "impacto", "de", "la", "tecnología", "en", "la", "industria", "del", "entretenimiento,", "estos", "campos", "reflejan", "y", "dan", "forma", "a",    "nuestra", "identidad", "cultural.",    "En", "el", "mundo", "cinematográfico,", "las", "nuevas", "tendencias", "y", "tecnologías", "como", "la", "realidad", "virtual", "han", "cambiado", "la", "forma", "en", "que",    "experimentamos", "las", "historias.", "Las", "producciones", "audiovisuales", "innovadoras", "y", "los", "efectos", "visuales", "avanzados", "han", "ampliado", "los", "límites",    "de", "la", "narrativa.",    "En", "la", "industria", "musical,", "plataformas", "de", "streaming", "y", "tecnologías", "de", "reproducción", "han", "transformado", "la", "forma", "en", "que", "consumimos",    "y", "descubrimos", "música.", "Los", "artistas", "utilizan", "las", "redes", "sociales", "y", "las", "plataformas", "digitales", "para", "conectar", "directamente", "con",    "sus", "seguidores.",        "En", "el", "ámbito", "literario,", "la", "tecnología", "ha", "facilitado", "el", "acceso", "a", "libros", "a", "través", "de", "dispositivos", "digitales", "y", "plataformas",    "de", "lectura", "en", "línea.", "Esto", "ha", "abierto", "nuevas", "oportunidades", "para", "escritores", "y", "lectores", "por", "igual.",        "La", "cultura", "pop", "y", "las", "tendencias", "en", "redes", "sociales", "influyen", "en", "la", "moda,", "el", "arte", "y", "la", "forma", "en", "que", "nos", "comunicamos.",    "La", "creación", "de", "contenidos", "en", "plataformas", "como", "YouTube", "y", "TikTok", "permite", "a", "individuos", "de", "todo", "el", "mundo", "expresar", "su",    "creatividad", "y", "conectar", "con", "audiencias", "globales.",        "En", "resumen,", "la", "cultura", "y", "el", "entretenimiento", "evolucionan", "constantemente", "con", "la", "influencia", "de", "las", "tecnologías", "emergentes.", "Estas",    "interacciones", "crean", "un", "tejido", "rico", "de", "experiencias", "que", "dan", "forma", "a", "nuestra", "identidad", "colectiva", "y", "reflejan", "nuestro", "constante",    "deseo", "de", "explorar", "nuevos", "horizontes", "culturales", "y", "entretenernos", "de", "formas", "innovadoras."};

                if (random > 0) {
                    for (i = CE.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = CE[i];
                        CE[i] = CE[j];
                        CE[j] = temp;
                    } 
                }
                txtpalabrasmostradas.Text = string.Join(" ", CE);
            }
            else if (tematica == "Ciencias Sociales")
            {
                string[] CS = {"Las", "ciencias", "sociales", "exploran", "los", "aspectos", "interactivos", "de", "la", "sociedad", "humana", "y", "sus", "instituciones.",    "Estas", "disciplinas", "analizan", "patrones", "de", "comportamiento", "individual", "y", "colectivo,", "dando", "una", "perspectiva", "amplia",    "sobre", "cómo", "las", "personas", "interactúan", "en", "diversos", "contextos.",        "La", "sociología", "es", "una", "de", "las", "ciencias", "sociales", "fundamentales.", "Examina", "cuestiones", "como", "la", "estructura", "social,",    "la", "estratificación", "y", "los", "cambios", "sociales.", "La", "antropología,", "por", "otro", "lado,", "se", "centra", "en", "el", "estudio", "de",    "las", "culturas", "y", "las", "sociedades", "humanas", "a", "lo", "largo", "del", "tiempo", "y", "en", "diversas", "regiones.",        "La", "economía", "es", "otra", "ciencia", "social", "importante,", "explorando", "cómo", "se", "administra", "y", "distribuye", "la", "riqueza", "en", "una",    "sociedad.", "Las", "ciencias", "políticas", "analizan", "la", "organización", "y", "funcionamiento", "de", "los", "gobiernos,", "mientras", "que", "la", "psicología",    "se", "centra", "en", "los", "procesos", "mentales", "y", "el", "comportamiento", "individual.",        "En", "las", "ciencias", "sociales,", "se", "exploran", "temas", "como", "la", "pobreza,", "la", "desigualdad", "social,", "el", "activismo", "y", "la", "diversidad",    "cultural.", "Estas", "disciplinas", "buscan", "comprender", "las", "dinámicas", "sociales", "y", "contribuir", "a", "soluciones", "para", "los", "desafíos",    "contemporáneos.",        "En", "resumen,", "las", "ciencias", "sociales", "nos", "brindan", "herramientas", "conceptuales", "y", "analíticas", "para", "entender", "y", "abordar", "los",    "aspectos", "complejos", "de", "la", "vida", "en", "sociedad,", "contribuyendo", "al", "desarrollo", "de", "políticas", "y", "prácticas", "que", "promueven",    "una", "sociedad", "más", "justa", "e", "inclusiva." };
                if (random > 0) {
                    for (i = CS.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = CS[i];
                        CS[i] = CS[j];
                        CS[j] = temp;
                    } 
                }
                txtpalabrasmostradas.Text = string.Join(" ", CS);
            }
            else if (tematica == "Historia y Eventos Actuales")
            {
                string[] HEA = {"La", "historia", "es", "un", "registro", "de", "nuestro", "pasado,", "un", "relato", "que", "nos", "conecta", "con", "los", "acontecimientos", "y", "las", "culturas",    "que", "han", "dado", "forma", "al", "mundo", "actual.", "Los", "eventos", "actuales", "son", "la", "continuación", "de", "esta", "narrativa,", "reflejando", "el",    "estado", "actual", "de", "nuestra", "sociedad", "y", "sus", "desafíos.",    "Desde", "la", "antigüedad", "hasta", "la", "era", "moderna,", "la", "historia", "ha", "estado", "marcada", "por", "eventos", "claves.", "La", "Edad", "Media", "vio",    "el", "auge", "de", "imperios", "y", "el", "florecimiento", "de", "culturas.", "La", "Revolución", "Industrial", "transformó", "la", "producción", "y", "la", "sociedad,",    "mientras", "que", "el", "siglo", "XX", "estuvo", "marcado", "por", "dos", "guerras", "mundiales", "y", "cambios", "políticos", "radicales.",    "En", "eventos", "actuales,", "la", "globalización", "y", "la", "tecnología", "han", "acercado", "a", "las", "naciones", "y", "han", "transformado", "la", "forma", "en",    "que", "nos", "conectamos.", "Los", "desafíos", "contemporáneos,", "como", "el", "cambio", "climático", "y", "las", "pandemias,", "nos", "instan", "a", "reflexionar",    "sobre", "nuestra", "relación", "con", "el", "planeta", "y", "cómo", "abordamos", "amenazas", "globales.",        "La", "historia", "y", "los", "eventos", "actuales", "son", "entrelazados,", "proporcionando", "una", "perspectiva", "valiosa", "sobre", "nuestro", "pasado", "y", "nuestro",    "futuro.", "El", "estudio", "de", "la", "historia", "nos", "ayuda", "a", "entender", "las", "raíces", "de", "nuestra", "sociedad", "actual", "y", "a", "tomar", "decisiones",    "informadas", "para", "el", "mañana." };
                if (random > 0)
                {
                    for (i = HEA.Length -1; i > 0; i--)
                    {
                        j = randomwords.Next(0,i+1);
                        temp = HEA[i];
                        HEA[i] = HEA[j];
                        HEA[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", HEA);
            }
            else if (tematica == "Salud y Bienestar")
            {
                string[] SB = {"La", "salud", "y", "el", "bienestar", "son", "aspectos", "fundamentales", "de", "una", "vida", "plena.", "Desde", "avances", "en", "la", "medicina", "hasta", "tendencias",    "en", "fitness", "y", "nutrición,", "estos", "temas", "nos", "invitan", "a", "reflexionar", "sobre", "nuestra", "relación", "con", "el", "cuerpo", "y", "la", "mente.",    "En", "el", "campo", "médico,", "los", "avances", "continuos", "han", "permitido", "tratamientos", "más", "precisos", "y", "accesibles.", "La", "biotecnología", "y", "las",    "terapias", "génicas", "abren", "nuevas", "posibilidades", "para", "el", "tratamiento", "de", "enfermedades", "antes", "consideradas", "incurables.", "La", "telesalud", "y",    "las", "aplicaciones", "móviles", "han", "transformado", "la", "forma", "en", "que", "accedemos", "a", "la", "atención", "médica.",    "La", "prevención", "y", "la", "promoción", "de", "la", "salud", "son", "temas", "clave.", "Desde", "programas", "de", "ejercicio", "y", "alimentación", "hasta", "prácticas",    "de", "bienestar", "mental,", "las", "personas", "buscan", "maneras", "de", "mejorar", "su", "calidad", "de", "vida.", "La", "nutrición", "y", "las", "dietas", "específicas",    "ganaron", "importancia,", "mientras", "que", "el", "mindfulness", "y", "la", "meditación", "se", "integran", "cada", "vez", "más", "en", "rutinas", "diarias.",    "La", "actividad", "física", "y", "el", "ejercicio", "son", "parte", "esencial", "de", "un", "estilo", "de", "vida", "saludable.", "Nuevas", "tecnologías", "de", "fitness", "y",    "dispositivos", "de", "seguimiento", "permiten", "a", "las", "personas", "personalizar", "sus", "rutinas", "y", "seguir", "su", "progreso.",    "En", "resumen,", "la", "salud", "y", "el", "bienestar", "son", "elementos", "cruciales", "de", "una", "vida", "equilibrada.", "El", "equilibrio", "entre", "cuerpo", "y", "mente",    "es", "fundamental", "para", "alcanzar", "un", "estado", "óptimo", "de", "salud", "y", "felicidad." };
                if (random > 0)
                {
                    for (i = SB.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = SB[i];
                        SB[i] = SB[j];
                        SB[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", SB);
            }
            else if (tematica == "Medio Ambiente")
            {
                string[] MA = {"El", "medio", "ambiente", "es", "un", "componente", "fundamental", "de", "nuestra", "existencia,", "y", "su", "preservación", "es", "esencial", "para", "garantizar", "un",    "futuro", "sostenible", "para", "las", "generaciones", "venideras.", "Los", "desafíos", "ambientales", "actuales", "nos", "obligan", "a", "reflexionar", "sobre", "nuestro",    "impacto", "en", "el", "planeta", "y", "a", "buscar", "soluciones", "innovadoras.",    "El", "cambio", "climático", "es", "uno", "de", "los", "principales", "problemas", "ambientales", "que", "enfrentamos.", "Las", "actividades", "humanas,", "como", "la",    "quema", "de", "combustibles", "fósiles", "y", "la", "deforestación,", "contribuyen", "a", "la", "emisión", "de", "gases", "de", "efecto", "invernadero,", "lo", "que",    "afecta", "el", "clima", "global.", "La", "necesidad", "de", "transición", "hacia", "fuentes", "de", "energía", "limpias", "es", "cada", "vez", "más", "urgente.",    "La", "conservación", "de", "la", "biodiversidad", "es", "otro", "aspecto", "crucial", "del", "cuidado", "del", "medio", "ambiente.", "La", "pérdida", "de", "hábitats",    "naturales", "y", "la", "contaminación", "amenazan", "a", "numerosas", "especies.", "La", "protección", "de", "los", "ecosistemas", "y", "la", "promoción", "de", "prácticas",    "sostenibles", "son", "esenciales", "para", "mantener", "la", "diversidad", "biológica.",    "La", "gestión", "de", "residuos", "y", "la", "economía", "circular", "son", "elementos", "clave", "en", "la", "promoción", "de", "un", "medio", "ambiente", "saludable.",    "Reducir", "el", "consumo", "de", "plásticos", "y", "fomentar", "el", "reciclaje", "son", "acciones", "importantes", "para", "mitigar", "la", "contaminación", "ambiental.",    "En", "resumen,", "la", "preservación", "del", "medio", "ambiente", "requiere", "acciones", "colectivas", "y", "cambios", "en", "nuestros", "hábitos", "cotidianos.",    "La", "conciencia", "ambiental", "y", "la", "adopción", "de", "prácticas", "sostenibles", "son", "esenciales", "para", "garantizar", "un", "equilibrio", "armonioso",    "entre", "la", "humanidad", "y", "la", "naturaleza." };
                if (random > 0)
                {
                    for (i = MA.Length -1; i > 0;i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = MA[i];
                        MA[i] = MA[j];
                        MA[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", MA);
            }
            else if (tematica == "Educación")
            {
                string[] E = {"La", "educación", "es", "un", "pilar", "fundamental", "para", "el", "desarrollo", "individual", "y", "colectivo.", "Juega", "un", "papel", "crucial", "en", "la",    "formación", "de", "individuos", "y", "en", "la", "construcción", "de", "sociedades", "prósperas", "y", "equitativas.", "Desde", "la", "educación", "infantil", "hasta",    "la", "formación", "superior,", "cada", "nivel", "contribuye", "a", "la", "capacitación", "y", "el", "crecimiento", "de", "las", "personas.",    "Los", "sistemas", "educativos", "deben", "adaptarse", "a", "las", "necesidades", "cambiantes", "de", "la", "sociedad", "y", "preparar", "a", "los", "estudiantes", "para",    "los", "desafíos", "del", "siglo", "XXI.", "La", "integración", "de", "tecnologías", "educativas,", "el", "enfoque", "en", "habilidades", "críticas", "y", "creativas,",    "y", "la", "promoción", "de", "la", "inclusividad", "son", "aspectos", "claves", "en", "la", "evolución", "de", "los", "sistemas", "educativos.",    "La", "educación", "no", "solo", "se", "limita", "a", "las", "aulas.", "El", "aprendizaje", "continuo", "y", "la", "formación", "profesional", "son", "esenciales", "en",    "un", "mundo", "en", "constante", "cambio.", "La", "educación", "a", "lo", "largo", "de", "toda", "la", "vida", "permite", "a", "las", "personas", "adaptarse", "a", "las",    "nuevas", "tecnologías", "y", "desarrollar", "habilidades", "relevantes.",    "La", "educación", "también", "juega", "un", "papel", "fundamental", "en", "la", "promoción", "de", "valores", "como", "la", "tolerancia,", "el", "respeto", "y", "la",    "responsabilidad", "cívica.", "Contribuye", "a", "la", "formación", "de", "ciudadanos", "conscientes", "y", "comprometidos", "con", "el", "bienestar", "común.",    "En", "resumen,", "la", "educación", "es", "una", "herramienta", "poderosa", "que", "moldea", "el", "futuro", "de", "las", "sociedades", "y", "promueve", "el", "desarrollo",    "integral", "de", "las", "personas." };
                if (random > 0)
                {
                    for (i = E.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = E[i];
                        E[i] = E[j];
                        E[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", E);
            }
            else if (tematica == "Tendencias en Estilo de Vida")
            {
                string[] TEV = { "El", "estilo", "de", "vida", "es", "una", "expresión", "individual", "que", "refleja", "cómo", "las", "personas", "abordan", "su", "día", "a", "día", "y", "buscan", "un", "equilibrio", "entre", "el", "trabajo,", "el", "ocio", "y", "el", "bienestar.", "Las", "tendencias", "en", "estilo", "de", "vida", "evolucionan", "constantemente,", "influidas", "por", "factores", "sociales,", "tecnológicos", "y", "culturales.", "En", "la", "actualidad,", "la", "salud", "mental", "y", "el", "bienestar", "son", "prioridades", "clave", "en", "las", "tendencias", "de", "estilo", "de", "vida.", "La", "práctica", "de", "mindfulness", "y", "la", "atención", "plena", "han", "ganado", "popularidad,", "mientras", "que", "el", "auto-cuidado", "y", "las", "rutinas", "que", "promueven", "la", "salud", "mental", "son", "elementos", "centrales.", "La", "sostenibilidad", "también", "ha", "influenciado", "las", "tendencias", "en", "estilo", "de", "vida.", "La", "conciencia", "ambiental", "se", "refleja", "en", "decisiones", "como", "el", "consumo", "responsable,", "la", "preferencia", "por", "productos", "ecológicos", "y", "un", "enfoque", "en", "la", "reducción", "de", "desperdicios.", "La", "tecnología", "también", "ha", "cambiado", "la", "forma", "en", "que", "las", "personas", "viven", "sus", "vidas.", "Desde", "el", "teletrabajo", "hasta", "las", "plataformas", "de", "entretenimiento", "en", "línea,", "la", "digitalización", "influye", "en", "cómo", "nos", "conectamos", "y", "organizamos", "nuestro", "tiempo.", "Las", "tendencias", "en", "alimentación", "y", "actividad", "física", "también", "evolucionan.", "La", "preferencia", "por", "dietas", "más", "sanas,", "como", "el", "veganismo", "y", "la", "comida", "orgánica,", "y", "el", "interés", "en", "prácticas", "de", "fitness", "innovadoras", "son", "parte", "integral", "de", "muchos", "estilos", "de", "vida.", "En", "resumen,", "las", "tendencias", "en", "estilo", "de", "vida", "reflejan", "las", "prioridades", "cambiantes", "de", "las", "sociedades", "modernas.", "Desde", "el", "enfoque", "en", "la", "salud", "mental", "hasta", "la", "sostenibilidad", "y", "la", "integración", "de", "tecnologías", "innovadoras,", "el", "estilo", "de", "vida", "es", "un", "terreno", "dinámico", "y", "en", "constante", "evolución." };
                if (random > 0)
                {
                    for (i = TEV.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = TEV[i];
                        TEV[i] = TEV[j];
                        TEV[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", TEV);
            }
            else if (tematica == "Viajes y Culturas")
            {
                string[] VC = { "Los", "viajes", "son", "una", "oportunidad", "para", "explorar", "el", "mundo", "y", "sumergirse", "en", "diversas", "culturas.", "Cada", "destino", "ofrece", "una", "experiencia", "única", "que", "va", "más", "allá", "de", "los", "paisajes", "y", "los", "sitios", "históricos,", "permitiéndonos", "conectar", "con", "las", "tradiciones", "y", "las", "historias", "locales.", "La", "diversidad", "cultural", "es", "evidente", "en", "las", "costumbres,", "la", "gastronomía", "y", "las", "formas", "de", "vida.", "Los", "viajes", "nos", "invitan", "a", "salir", "de", "nuestra", "zona", "de", "confort", "y", "a", "abrazar", "nuevas", "perspectivas.", "Ya", "sea", "explorando", "los", "mercados", "locales", "o", "participando", "en", "festivales", "tradicionales,", "cada", "encuentro", "cultural", "amplía", "nuestra", "comprensión", "del", "mundo.", "Los", "viajes", "sostenibles", "han", "ganado", "relevancia,", "promoviendo", "la", "preservación", "de", "la", "cultura", "local", "y", "la", "responsabilidad", "ambiental.", "La", "interacción", "respetuosa", "con", "las", "comunidades", "locales", "y", "el", "turismo", "ético", "son", "elementos", "clave", "en", "esta", "tendencia.", "La", "tecnología", "ha", "transformado", "la", "forma", "en", "que", "planeamos", "y", "experimentamos", "viajes.", "Las", "aplicaciones", "de", "viaje", "y", "las", "redes", "sociales", "nos", "permiten", "descubrir", "nuevos", "lugares", "y", "conectar", "con", "viajeros", "de", "todo", "el", "mundo.", "En", "resumen,", "los", "viajes", "nos", "brindan", "la", "oportunidad", "de", "explorar", "la", "diversidad", "cultural", "de", "nuestro", "planeta.", "Cada", "viaje", "es", "una", "aventura", "única", "que", "nos", "enseña", "sobre", "nuestro", "mundo", "y", "nuestra", "propia", "identidad", "en", "un", "contexto", "global." };
                if (random > 0)
                {
                    for (i = VC.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = VC[i];
                        VC[i] = VC[j];
                        VC[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", VC);
            }
            else if (tematica == "Exploración Espacial")
            {
                string[] EE = {"La", "exploración", "espacial", "es", "una", "empresa", "que", "ha", "capturado", "la", "imaginación", "de", "la", "humanidad", "durante", "décadas.", "Desde", "los",    "primeros", "vuelos", "espaciales", "hasta", "las", "misiones", "más", "recientes,", "cada", "logro", "representa", "un", "paso", "hacia", "el", "entendimiento", "del",    "universo", "y", "nuestro", "lugar", "en", "él.",    "La", "exploración", "espacial", "comenzó", "con", "satélites", "y", "sondas", "que", "observaban", "nuestro", "planeta", "y", "el", "espacio", "cercano.", "Luego,", "los",    "seres", "humanos", "cruzaron", "la", "frontera", "del", "espacio", "con", "misiones", "pioneras", "como", "la", "del", "Apollo", "11,", "que", "llevó", "a", "los", "primeros",    "astronautas", "a", "la", "Luna", "en", "1969.",    "En", "la", "actualidad,", "las", "agencias", "espaciales", "de", "todo", "el", "mundo", "colaboran", "en", "misiones", "para", "explorar", "otros", "cuerpos", "celestes.",    "Rovers", "como", "Curiosity", "exploran", "la", "superficie", "de", "Marte,", "telescopios", "espaciales", "como", "Hubble", "nos", "ofrecen", "vistas", "lejanas", "del",    "universo", "y", "sondas", "como", "Voyager", "se", "han", "adentrado", "en", "el", "espacio", "interestelar.",    "La", "exploración", "espacial", "no", "solo", "se", "limita", "a", "los", "astronautas", "y", "las", "misiones", "robotizadas.", "Empresas", "privadas", "están",    "desarrollando", "tecnologías", "para", "llevar", "a", "los", "humanos", "a", "otros", "planetas", "y", "hasta", "colonizar", "otros", "cuerpos", "celestes.",    "En", "resumen,", "la", "exploración", "espacial", "es", "un", "viaje", "constante", "hacia", "lo", "desconocido,", "expandiendo", "nuestros", "límites", "y", "descubriendo",    "los", "secretos", "del", "universo." };
                if (random > 0)
                {
                    for (i = EE.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = EE[i];
                        EE[i] = EE[j];
                        EE[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", EE);
            }
            else if (tematica == "misiones espaciales y descubrimientos")
            {
                string[] MED = {"Las", "misiones", "espaciales", "han", "sido", "instrumentales", "en", "nuestro", "entendimiento", "del", "universo,", "llevándonos", "a", "descubrimientos", "asombrosos.",    "Desde", "las", "primeras", "exploraciones", "hasta", "las", "misiones", "más", "recientes,", "cada", "viaje", "al", "espacio", "ha", "ampliado", "nuestra", "perspectiva",    "y", "ha", "contribuido", "a", "nuestro", "conocimiento", "científico.",    "Una", "de", "las", "misiones", "más", "icónicas", "fue", "el", "Apollo", "11,", "la", "primera", "misión", "que", "llevó", "a", "humanos", "a", "la", "Luna", "en", "1969.",    "Este", "logro", "histórico", "abrió", "nuevas", "posibilidades", "y", "despertó", "el", "interés", "por", "la", "exploración", "lunar.",    "Misiones", "robóticas,", "como", "las", "realizadas", "por", "rovers", "en", "Marte,", "han", "proporcionado", "datos", "valiosos", "sobre", "la", "composición", "y", "la",    "historia", "de", "otros", "planetas.", "El", "rover", "Curiosity", "ha", "analizado", "rocas", "y", "suelo", "en", "Marte,", "ayudándonos", "a", "entender", "las",    "condiciones", "pasadas", "del", "planeta", "rojo.",    "Misiones", "telescopio,", "como", "el", "Hubble,", "han", "revolucionado", "nuestra", "comprensión", "del", "cosmos.", "El", "Hubble", "ha", "capturado", "imágenes",    "profundas", "del", "espacio", "lejano", "y", "ha", "contribuido", "a", "la", "determinación", "de", "la", "tasa", "de", "expansión", "del", "universo.",    "Descubrimientos", "recientes", "incluyen", "la", "confirmación", "de", "exoplanetas", "en", "zonas", "habitable,", "lo", "que", "sugiere", "la", "posibilidad", "de",    "vida", "más", "allá", "de", "nuestro", "sistema", "solar.", "La", "misión", "Kepler", "y", "otros", "telescopios", "han", "contribuido", "a", "esta", "emocionante",    "búsqueda", "de", "mundos", "similares", "al", "nuestro.",    "En", "resumen,", "las", "misiones", "espaciales", "y", "los", "descubrimientos", "resultantes", "han", "transformado", "nuestra", "comprensión", "del", "universo",    "y", "nos", "han", "inspirado", "a", "seguir", "explorando", "los", "misterios", "del", "espacio." };
                if (random > 0)
                {
                    for (i = MED.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = MED[i];
                        MED[i] = MED[j];
                        MED[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", MED);
            }
            else if (tematica == "Tecnologías Emergentes")
            {
                string[] TE = { "Las", "tecnologías", "emergentes", "son", "innovaciones", "que", "están", "transformando", "rápidamente", "nuestra", "forma", "de", "vivir", "y", "trabajar.", "Estas",    "tecnologías", "van", "más", "allá", "de", "las", "tendencias", "actuales,", "ofreciendo", "nuevas", "perspectivas", "y", "oportunidades.",    "La", "inteligencia", "artificial", "(IA)", "es", "una", "de", "las", "tecnologías", "emergentes", "más", "impactantes.", "Desde", "algoritmos", "de", "aprendizaje",    "profundo", "hasta", "sistemas", "de", "procesamiento", "del", "lenguaje", "natural,", "la", "IA", "está", "revolucionando", "la", "forma", "en", "que", "las",    "máquinas", "aprenden", "y", "realizan", "tareas", "complejas.",    "La", "computación", "cuántica", "es", "otro", "campo", "emergente", "que", "promete", "cambios", "radicales.", "Los", "ordenadores", "cuánticos", "pueden", "realizar",    "cálculos", "a", "una", "velocidad", "y", "escala", "que", "supera", "a", "los", "ordenadores", "tradicionales.", "Esto", "tendrá", "un", "impacto", "significativo",    "en", "la", "criptografía,", "la", "simulación", "de", "materiales", "y", "otros", "ámbitos", "científicos.",    "Las", "tecnologías", "de", "realidad", "aumentada", "y", "virtual", "están", "transformando", "nuestra", "experiencia", "del", "mundo.", "Desde", "aplicaciones",    "de", "entretenimiento", "hasta", "entornos", "de", "trabajo", "remoto,", "estas", "tecnologías", "amplían", "nuestra", "interacción", "con", "la", "información",    "y", "nuestro", "entorno.",    "La", "tecnología", "blockchain", "ofrece", "un", "nuevo", "paradigma", "para", "la", "gestión", "de", "registros", "y", "transacciones.", "La", "descentralización",    "y", "la", "seguridad", "que", "ofrece", "la", "blockchain", "tienen", "aplicaciones", "en", "áreas", "como", "las", "finanzas", "y", "la", "cadena", "de", "suministro.",    "En", "resumen,", "las", "tecnologías", "emergentes", "nos", "están", "guiando", "hacia", "un", "futuro", "tecnológico", "que", "promete", "innovación", "continua",   "y", "cambios", "transformadores." };
                if (random > 0)
                {
                    for (i = TE.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = TE[i];
                        TE[i] = TE[j];
                        TE[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", TE);
            }
            else if (tematica == "Realidad virtual")
            {
                string[] RV = {"La", "realidad", "virtual", "(RV)", "es", "una", "tecnología", "que", "ha", "transformado", "la", "forma", "en", "que", "experimentamos", "y", "percibimos", "el", "entorno.",    "Utilizando", "tecnología", "computacional", "avanzada", "y", "dispositivos", "especiales,", "la", "RV", "crea", "un", "entorno", "inmersivo", "que", "puede", "ser",    "simulado", "o", "similar", "a", "la", "realidad.",    "Los", "dispositivos", "de", "realidad", "virtual,", "como", "gafas", "VR", "y", "controladores", "de", "movimiento,", "permiten", "a", "los", "usuarios", "sumergirse",    "en", "entornos", "virtuales.", "Estos", "pueden", "ser", "utilizados", "en", "diversos", "campos,", "desde", "juegos", "y", "entretenimiento", "hasta", "aplicaciones",    "educativas", "y", "entrenamiento", "profesional.",    "En", "la", "industria", "del", "entretenimiento,", "la", "RV", "ha", "abierto", "nuevas", "posibilidades", "para", "la", "creación", "de", "experiencias", "inmersivas.",    "Juegos", "y", "simuladores", "pueden", "transportar", "a", "los", "jugadores", "a", "mundos", "virtuales", "interactivos,", "proporcionando", "una", "sensación",    "de", "presencia", "y", "emoción", "única.",    "En", "el", "ámbito", "educativo,", "la", "RV", "se", "utiliza", "para", "crear", "entornos", "de", "aprendizaje", "inmersivos.", "Los", "estudiantes", "pueden",    "explorar", "lugares", "históricos,", "viajar", "al", "espacio", "o", "sumergirse", "en", "procesos", "biológicos", "de", "una", "manera", "interactiva.",    "En", "el", "sector", "profesional,", "la", "RV", "se", "utiliza", "para", "entrenamiento", "en", "simulaciones", "realistas,", "desde", "cirugía", "hasta",    "entrenamiento", "de", "pilotos.", "Esto", "permite", "a", "los", "profesionales", "adquirir", "experiencia", "práctica", "en", "entornos", "seguros", "y",    "controlados.",    "En", "resumen,", "la", "realidad", "virtual", "es", "una", "tecnología", "que", "ha", "transformado", "la", "forma", "en", "que", "vivimos", "y", "aprendemos,",    "proporcionando", "experiencias", "inmersivas", "que", "abren", "nuevos", "horizontes", "en", "el", "mundo", "digital." };
                if (random > 0)
                {
                    for (i = RV.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = RV[i];
                        RV[i] = RV[j];
                        RV[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", RV);
            }
            else if (tematica == "Blockchain y criptomonedas")
            {
                string[] BC = { "La", "tecnología", "blockchain", "y", "las", "criptomonedas", "han", "sido", "innovaciones", "transformadoras", "en", "el", "mundo", "de", "las", "finanzas", "y",    "más", "allá.", "La", "blockchain,", "una", "cadena", "de", "bloques", "interconectados", "que", "almacena", "información", "de", "forma", "segura", "y", "transparente,",    "es", "la", "base", "de", "las", "criptomonedas.",    "Las", "criptomonedas,", "como", "Bitcoin,", "son", "monedas", "digitales", "que", "utilizan", "cifrado", "para", "asegurar", "transacciones", "y", "controlar", "la",    "creación", "de", "nuevas", "unidades.", "Estas", "operan", "en", "una", "red", "de", "usuarios", "que", "verifican", "y", "registran", "cada", "transacción", "en", "la",    "blockchain.",    "La", "blockchain", "ofrece", "una", "forma", "segura", "y", "transparente", "de", "gestionar", "transacciones.", "Cada", "bloque", "contiene", "un", "registro",    "de", "transacciones", "que", "es", "enlazado", "al", "bloque", "anterior,", "lo", "que", "hace", "que", "la", "manipulación", "de", "datos", "sea", "extremadamente",    "difícil.",    "Bitcoin,", "la", "primera", "criptomoneda", "exitosa,", "introdujo", "el", "concepto", "de", "prueba", "de", "trabajo", "para", "asegurar", "la", "red.", "Otras",    "criptomonedas,", "como", "Ethereum,", "han", "ampliado", "el", "alcance", "de", "la", "blockchain", "al", "permitir", "contratos", "inteligentes,", "que",    "son", "programas", "autónomos", "que", "ejecutan", "automáticamente", "términos", "de", "contratos.",    "La", "tecnología", "blockchain", "se", "está", "explorando", "en", "diversos", "sectores,", "desde", "la", "gestión", "de", "cadenas", "de", "suministro",    "hasta", "la", "votación", "electrónica.", "Su", "naturaleza", "descentralizada", "ofrece", "seguridad", "y", "transparencia.",    "En", "resumen,", "la", "tecnología", "blockchain", "y", "las", "criptomonedas", "han", "introducido", "nuevos", "paradigmas", "en", "la", "forma", "en", "que",    "manejamos", "transacciones", "y", "aseguramos", "la", "integridad", "de", "los", "datos", "en", "el", "mundo", "digital." };
                if (random > 0)
                {
                    for (i = BC.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = BC[i];
                        BC[i] = BC[j];
                        BC[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", BC);
            }
            else if (tematica == "Desarrollos en robótica y automatización")
            {
                string[] DRA = {"Los", "avances", "en", "robótica", "y", "automatización", "han", "transformado", "la", "forma", "en", "que", "trabajamos", "y", "vivimos.", "Desde", "la", "industria",    "hasta", "los", "hogares,", "estas", "tecnologías", "han", "introducido", "innovaciones", "que", "optimizan", "tareas", "y", "amplían", "nuestras", "capacidades.",    "En", "la", "industria,", "los", "robots", "han", "asumido", "tareas", "repetitivas", "y", "peligrosas,", "permitiendo", "que", "los", "trabajadores", "se",    "enfoquen", "en", "tareas", "más", "sofisticadas", "y", "creativas.", "Los", "sistemas", "de", "automatización", "han", "mejorado", "la", "eficiencia", "y",    "la", "precisión", "en", "la", "producción,", "contribuyendo", "a", "la", "innovación", "y", "la", "competitividad", "en", "el", "mercado.",    "En", "el", "ámbito", "médico,", "la", "robótica", "ha", "desempeñado", "un", "papel", "importante", "en", "cirugías", "mínimamente", "invasivas", "y", "procedimientos",    "de", "rehabilitación.", "Los", "robots", "quirúrgicos", "asisten", "a", "los", "cirujanos", "con", "precisión", "y", "control", "mejorados,", "mientras", "que",    "exoesqueletos", "robotizados", "facilitan", "la", "rehabilitación", "de", "pacientes.",    "En", "el", "hogar,", "la", "automatización", "residencial", "ha", "crecido", "en", "popularidad.", "Sistemas", "inteligentes", "permiten", "el", "control",   "remoto", "de", "dispositivos", "y", "la", "automatización", "de", "tareas", "domésticas.", "Desde", "asistentes", "virtuales", "hasta", "aspiradoras",    "robóticas,", "estas", "tecnologías", "hacen", "la", "vida", "cotidiana", "más", "conveniente", "y", "eficiente.",    "El", "desarrollo", "de", "inteligencia", "artificial", "ha", "contribuido", "a", "mejorar", "la", "capacidad", "de", "los", "robots", "para", "aprender",    "y", "adaptarse.", "Estos", "pueden", "responder", "a", "entornos", "cambiantes", "y", "realizar", "tareas", "más", "complejas", "con", "menor", "supervisión.",    "En", "resumen,", "los", "desarrollos", "en", "robótica", "y", "automatización", "están", "moldeando", "el", "futuro", "de", "la", "producción,", "la",    "medicina", "y", "la", "vida", "cotidiana,", "brindando", "oportunidades", "y", "desafíos", "que", "continuarán", "evolucionando." };
                if (random > 0)
                {
                    for (i = DRA.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = DRA[i];
                        DRA[i] = DRA[j];
                        DRA[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", DRA);
            }
            else if (tematica == "Psicología y Bienestar Mental")
            {
                string[] PBM = {"La", "psicología", "y", "el", "bienestar", "mental", "son", "áreas", "que", "exploran", "la", "mente", "humana,", "las", "emociones", "y", "los", "factores",    "que", "contribuyen", "a", "una", "vida", "saludable.", "Estas", "disciplinas", "ofrecen", "herramientas", "para", "comprender", "y", "mejorar", "nuestra",    "calidad", "de", "vida", "en", "diferentes", "aspectos.",    "La", "psicología", "aborda", "el", "estudio", "de", "la", "mente", "y", "el", "comportamiento", "humano.", "Desde", "las", "teorías", "clásicas", "hasta",    "los", "enfoques", "modernos,", "la", "psicología", "explora", "temas", "como", "el", "desarrollo", "humano,", "los", "trastornos", "mentales,", "la",    "psicología", "clínica", "y", "la", "psicología", "positiva.",    "El", "bienestar", "mental", "se", "refiere", "al", "estado", "general", "de", "equilibrio", "emocional", "y", "psicológico.", "Incluye", "aspectos", "como",    "la", "gestión", "del", "estrés,", "el", "desarrollo", "de", "habilidades", "emocionales", "y", "la", "promoción", "de", "una", "mentalidad", "positiva.",    "Practicar", "el", "auto-cuidado", "y", "buscar", "apoyo", "profesional", "son", "elementos", "claves", "para", "mantener", "un", "bienestar", "mental",    "óptimo.",    "La", "terapia", "psicológica", "y", "las", "intervenciones", "en", "salud", "mental", "juegan", "un", "papel", "vital", "en", "el", "tratamiento", "de",    "trastornos", "mentales", "y", "el", "mejoramiento", "del", "bienestar", "psicológico.", "Enfoques", "como", "la", "terapia", "cognitivo-conductual",    "y", "la", "terapia", "de", "mindfulness", "son", "utilizados", "para", "abordar", "diferentes", "necesidades", "y", "metas", "individuales.",    "La", "promoción", "de", "la", "salud", "mental", "es", "fundamental", "en", "la", "prevención", "de", "trastornos", "y", "el", "fomento", "de", "una", "vida",    "plena.", "Educación", "sobre", "la", "salud", "mental", "y", "prácticas", "como", "la", "meditación", "y", "el", "ejercicio", "regular", "son", "parte",    "integral", "de", "cuidar", "nuestra", "mente.",    "En", "resumen,", "la", "psicología", "y", "el", "bienestar", "mental", "trabajan", "juntos", "para", "promover", "una", "comprensión", "profunda", "de",   "nuestra", "mente", "y", "cultivar", "una", "vida", "equilibrada", "y", "saludable." };
                if (random > 0)
                {
                    for (i = PBM.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = PBM[i];
                        PBM[i] = PBM[j];
                        PBM[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", PBM);
            }
            else if (tematica == "Nutrición y Alimentación")
            {
                string[] NA = {"La", "nutrición", "y", "la", "alimentación", "son", "componentes", "esenciales", "para", "mantener", "una", "vida", "saludable", "y", "un", "bienestar", "óptimo.",    "Estas", "disciplinas", "se", "centran", "en", "los", "alimentos", "que", "ingerimos,", "sus", "nutrientes", "y", "cómo", "influyen", "en", "nuestra", "salud.",    "La", "nutrición", "es", "el", "proceso", "mediante", "el", "cual", "el", "cuerpo", "absorbe", "y", "utiliza", "los", "nutrientes", "de", "los", "alimentos.",    "Estos", "nutrientes", "incluyen", "proteínas,", "carbohidratos,", "grasas,", "vitaminas", "y", "minerales.", "Una", "dieta", "equilibrada", "y", "variada", "es",    "clave", "para", "garantizar", "que", "obtenemos", "todos", "los", "nutrientes", "necesarios", "para", "nuestro", "bienestar.",    "Los", "alimentos", "que", "consumimos", "no", "solo", "proporcionan", "energía,", "sino", "que", "también", "tienen", "un", "impacto", "en", "nuestra", "salud",    "general.", "Una", "alimentación", "rica", "en", "frutas,", "verduras,", "granos", "enteros", "y", "proteínas", "magras", "puede", "contribuir", "a", "prevenir",    "enfermedades", "y", "mantener", "un", "peso", "saludable.",    "La", "educación", "nutricional", "juega", "un", "papel", "importante", "en", "ayudarnos", "a", "tomar", "decisiones", "informadas", "sobre", "nuestra", "dieta.",    "Comprender", "los", "principios", "básicos", "de", "la", "nutrición", "nos", "permite", "seleccionar", "alimentos", "que", "satisfacen", "nuestras", "necesidades",    "nutricionales", "y", "promueven", "la", "salud.",    "La", "nutrición", "también", "juega", "un", "papel", "clave", "en", "el", "rendimiento", "físico", "y", "mental.", "Una", "alimentación", "adecuada", "puede",   "mejorar", "la", "concentración,", "la", "energía", "y", "la", "resistencia.", "Los", "nutrientes", "que", "proporcionamos", "a", "nuestro", "cuerpo",    "influyen", "directamente", "en", "nuestra", "capacidad", "para", "realizar", "actividades", "cotidianas", "y", "alcanzar", "nuestros", "objetivos.",    "En", "resumen,", "la", "nutrición", "y", "la", "alimentación", "son", "elementos", "esenciales", "para", "mantener", "un", "cuerpo", "y", "una", "mente",    "saludables.", "Elegir", "alimentos", "nutrientes", "y", "adoptar", "hábitos", "alimentarios", "saludables", "son", "decisiones", "que", "contribuyen", "a",    "nuestro", "bienestar", "a", "largo", "plazo." };
                if (random > 0)
                {
                    for (i = NA.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = NA[i];
                        NA[i] = NA[j];
                        NA[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", NA);
            }
            else if (tematica == "Innovación Empresarial")
            {
                string[] IE = {"La", "innovación", "empresarial", "es", "un", "elemento", "fundamental", "para", "el", "éxito", "y", "la", "sostenibilidad", "en", "el", "entorno", "empresarial", "actual.",    "Se", "refiere", "a", "la", "creación", "y", "aplicación", "de", "nuevas", "ideas,", "procesos", "o", "productos", "que", "generan", "valor", "y", "ventajas", "competitivas.",    "La", "innovación", "puede", "ocurrir", "en", "diversos", "ámbitos,", "desde", "productos", "y", "servicios", "hasta", "modelos", "de", "negocio", "y", "procesos", "internos.",    "Las", "empresas", "innovadoras", "buscan", "constantemente", "maneras", "de", "mejorar", "y", "adaptarse", "a", "las", "cambiantes", "necesidades", "del", "mercado.",    "La", "tecnología", "juega", "un", "papel", "clave", "en", "la", "innovación", "empresarial.", "Desde", "la", "automatización", "hasta", "la", "inteligencia", "artificial",    "y", "el", "análisis", "de", "datos,", "las", "empresas", "utilizan", "avances", "tecnológicos", "para", "impulsar", "la", "eficiencia", "y", "la", "creatividad.",    "La", "cultura", "organizacional", "juega", "un", "papel", "fundamental", "en", "fomentar", "la", "innovación.", "Empresas", "que", "fomentan", "la", "colaboración,",   "la", "tolerancia", "al", "riesgo", "y", "la", "creatividad", "suelen", "ser", "más", "exitosas", "en", "la", "implementación", "de", "nuevas", "ideas.",    "La", "innovación", "no", "solo", "implica", "crear", "nuevos", "productos", "o", "servicios,", "sino", "también", "reinventar", "y", "mejorar", "los", "existentes.",   "Empresas", "que", "adoptan", "una", "mentalidad", "de", "innovación", "constante", "pueden", "mantenerse", "competitivas", "en", "un", "entorno", "empresarial",   "dinámico.",    "La", "innovación", "empresarial", "es", "un", "proceso", "continuo", "que", "requiere", "flexibilidad", "y", "adaptabilidad.", "Aquellas", "empresas", "que", "se", "comprometen", "con", "la", "innovación", "tienen", "mayores", "oportunidades", "de", "crecimiento", "y", "éxito", "a", "largo", "plazo." };
                if (random > 0)
                {
                    for (i = IE.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = IE[i];
                        IE[i] = IE[j];
                        IE[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", IE);
            }
            else if (tematica == "Arquitectura y Diseño Urbano")
            {
                string[] AD = {"La", "arquitectura", "y", "el", "diseño", "urbano", "son", "disciplinas", "que", "dan", "forma", "y", "estructura", "a", "los", "entornos", "en", "los", "que","vivimos", "y", "trabajamos.", "Estas", "disciplinas", "no", "solo", "se", "centran", "en", "la", "creación", "de", "edificios", "y", "espacios", "públicos,","sino", "también", "en", "el", "impacto", "social,", "cultural", "y", "ambiental", "de", "estas", "creaciones.",    "La", "arquitectura", "es", "el", "arte", "y", "la", "ciencia", "de", "diseñar", "y", "construir", "espacios", "habitables.", "Los", "arquitectos", "no", "solo",   "consideran", "la", "funcionalidad", "y", "la", "estética,", "sino", "también", "factores", "como", "la", "sostenibilidad", "y", "la", "eficiencia", "energética.",    "El", "diseño", "urbano", "se", "refiere", "a", "la", "planificación", "y", "organización", "de", "los", "espacios", "urbanos.", "Incluye", "aspectos", "como",   "la", "distribución", "de", "edificios,", "calles", "y", "áreas", "verdes,", "así", "como", "la", "consideración", "de", "las", "necesidades", "de", "la", "comunidad.",  "La", "arquitectura", "y", "el", "diseño", "urbano", "modernos", "han", "adoptado", "principios", "de", "sostenibilidad", "y", "diseño", "inclusivo.", "La",   "creación", "de", "edificaciones", "ecológicas", "y", "espacios", "públicos", "accesibles", "promueve", "un", "entorno", "más", "equitativo", "y", "respetuoso",   "con", "el", "medio", "ambiente.",    "Las", "tendencias", "en", "arquitectura", "y", "diseño", "urbano", "también", "reflejan", "cambios", "en", "las", "necesidades", "y", "preferencias", "de", "la",   "sociedad.", "La", "introducción", "de", "tecnologías", "innovadoras,", "la", "creación", "de", "espacios", "flexibles", "y", "la", "promoción", "de", "la",   "movilidad", "sostenible", "son", "ejemplos", "de", "cómo", "la", "arquitectura", "y", "el", "diseño", "urbano", "evolucionan", "con", "el", "tiempo.",    "En", "resumen,", "la", "arquitectura", "y", "el", "diseño", "urbano", "son", "disciplinas", "dinámicas", "que", "dan", "forma", "a", "nuestro", "entorno",    "con", "consideraciones", "artísticas,", "funcionales", "y", "sociales.", "Su", "impacto", "se", "extiende", "más", "allá", "de", "los", "edificios,",   "contribuyendo", "a", "la", "calidad", "de", "vida", "y", "la", "identidad", "de", "las", "comunidades." };
                if (random > 0)
                {
                    for (i = AD.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = AD[i];
                        AD[i] = AD[j];
                        AD[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", AD);
            }
            else if (tematica == "Deportes y Rendimiento Físico")
            {
                string[] DRF = {"Los", "deportes", "y", "el", "rendimiento", "físico", "son", "componentes", "esenciales", "para", "mantener", "un", "estilo", "de", "vida", "activo", "y", "saludable.",    "La", "práctica", "de", "deportes", "no", "solo", "contribuye", "a", "la", "condición", "física", "sino", "también", "a", "la", "salud", "mental", "y", "al", "desarrollo",    "personal.",    "El", "entrenamiento", "deportivo", "se", "centra", "en", "mejorar", "las", "habilidades", "y", "el", "rendimiento", "físico.", "Incluye", "aspectos", "como",   "la", "fuerza,", "la", "velocidad,", "la", "resistencia", "y", "la", "flexibilidad.", "Los", "atletas", "dedican", "tiempo", "y", "esfuerzo", "a", "perfeccionar", "su", "desempeño", "y", "a", "alcanzar", "metas", "deportivas.",    "La", "variedad", "de", "deportes", "ofrece", "opciones", "para", "todos", "los", "niveles", "de", "aptitud", "y", "preferencias.", "Desde", "deportes", "colectivos",   "como", "fútbol", "y", "baloncesto", "hasta", "deportes", "individuales", "como", "natación", "y", "ciclismo,", "cada", "uno", "proporciona", "beneficios", "únicos.",   "El", "rendimiento", "físico", "no", "solo", "implica", "la", "práctica", "deportiva", "regular,", "sino", "también", "la", "atención", "a", "factores", "como",   "la", "nutrición", "y", "el", "descanso.", "Los", "atletas", "se", "enfrentan", "a", "demandas", "físicas", "intensas,", "y", "el", "cuidado", "del", "cuerpo",  "juega", "un", "papel", "clave", "en", "el", "mantenimiento", "de", "la", "salud", "y", "la", "prevención", "de", "lesiones.",   "El", "deporte", "no", "solo", "es", "un", "medio", "para", "mantenerse", "activo,", "sino", "también", "una", "oportunidad", "para", "desarrollar", "habilidades",  "sociales", "y", "valores", "como", "el", "trabajo", "en", "equipo", "y", "la", "resiliencia.", "La", "competencia", "deportiva", "fomenta", "el", "espíritu",  "competitivo", "y", "el", "logro", "personal.",  "En", "resumen,", "los", "deportes", "y", "el", "rendimiento", "físico", "son", "elementos", "clave", "para", "una", "vida", "saludable", "y", "equilibrada.",  "Participar", "en", "actividades", "deportivas", "no", "solo", "mejora", "la", "condición", "física,", "sino", "que", "también", "contribuye", "al", "bienestar",  "general", "y", "al", "desarrollo", "personal." };
                if (random > 0)
                {
                    for (i = DRF.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = DRF[i];
                        DRF[i] = DRF[j];
                        DRF[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", DRF);
            }
            else if (tematica == "Arqueología y Descubrimientos Históricos")
            {
                string[] ADH = {"La", "arqueología", "es", "una", "disciplina", "científica", "que", "se", "dedica", "a", "la", "exploración,", "estudio", "y", "interpretación", "de", "los", "restos", "materiales", "de", "culturas", "pasadas.", "Los", "descubrimientos", "arqueológicos", "juegan", "un", "papel", "fundamental", "en", "nuestra", "comprensión", "de", "la", "historia", "humana.", "Los", "sitios", "arqueológicos", "abarc", "un", "amplio", "espectro", "de", "periodos", "históricos,", "desde", "las", "antiguas", "civilizaciones", "hasta", "la", "época", "moderna.", "Excavaciones", "y", "descubrimientos", "en", "ciudades", "antiguas,", "tumbas", "reales", "y", "yacimientos", "prehistóricos", "ofrecen", "una", "ventana", "única", "al", "pasado.", "La", "tecnología", "juega", "un", "papel", "cada", "vez", "más", "importante", "en", "la", "arqueología.", "Métodos", "como", "la", "datación", "por", "carbono", "y", "las", "imágenes", "de", "satélite", "permiten", "a", "los", "arqueólogos", "refinar", "sus", "investigaciones", "y", "descubrir", "sitios", "que", "de", "otra", "manera", "podrían", "pasar", "inadvertidos.", "Descubrimientos", "emblemáticos", "como", "la", "tumba", "de", "Tutankamón", "en", "Egipto", "o", "la", "ciudad", "perdida", "de", "Machu", "Picchu", "en", "Perú", "han", "capturado", "la", "imaginación", "del", "mundo.", "Estos", "hallazgos", "no", "solo", "revelan", "información", "sobre", "las", "culturas", "antiguas,", "sino", "que", "también", "plantean", "nuevas", "preguntas", "sobre", "nuestra", "historia.", "El", "trabajo", "arqueológico", "es", "un", "proceso", "meticuloso", "que", "implica", "la", "documentación", "cuidadosa", "de", "cada", "hallazgo.", "Los","artefactos", "recuperados,", "junto", "con", "la", "información", "contextual,", "ayudan", "a", "los", "arqueólogos", "a", "reconstruir", "historias", "olvidadas.",  "En", "resumen,", "la", "arqueología", "y", "los", "descubrimientos", "históricos", "son", "esenciales", "para", "nuestra", "comprensión", "de", "la", "historia", "humana.", "Cada", "nuevo", "hallazgo", "nos", "acerca", "un", "poco", "más", "a", "las", "culturas", "del", "pasado", "y", "a", "las", "historias", "que", "han", "perdurado", "a", "través", "de", "los", "siglos." };
                if (random > 0)
                {
                    for (i = ADH.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = ADH[i];
                        ADH[i] = ADH[j];
                        ADH[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", ADH);
            }
            else if (tematica == "Desarrollo Personal")
            {
                string[] DP = {"El", "desarrollo", "personal", "es", "un", "proceso", "continuo", "de", "crecimiento", "y", "mejora", "individual,", "orientado", "a", "alcanzar", "el", "potencial","máximo", "en", "todas", "las", "áreas", "de", "la", "vida.", "Incluye", "aspectos", "como", "el", "autoconocimiento,", "el", "aprendizaje", "constante",    "y", "el", "establecimiento", "de", "metas", "personales.",   "La", "autoevaluación", "es", "un", "componente", "fundamental", "del", "desarrollo", "personal.", "Comprender", "nuestras", "fortalezas", "y", "debilidades",    "nos", "permite", "trabajar", "de", "manera", "eficaz", "en", "áreas", "que", "requieren", "mejora", "y", "capitalizar", "en", "nuestros", "talentos.",   "El", "aprendizaje", "continuo", "es", "clave", "para", "el", "desarrollo", "personal.", "Ya", "sea", "a", "través", "de", "la", "educación", "formal", "o",  "la", "adquisición", "de", "nuevas", "habilidades", "y", "conocimientos,", "el", "compromiso", "con", "el", "crecimiento", "intelectual", "contribuye", "a", "expandir", "nuestras", "perspectivas.","Establecer", "metas", "claras", "y", "realistas", "es", "esencial", "en", "el", "desarrollo", "personal.", "Las", "metas", "actúan", "como", "guías", "que", "nos", "dirigen", "hacia", "el", "éxito", "y", "nos", "motivan", "a", "mejorarnos", "continuamente.", "El", "seguimiento", "de", "nuestro", "progreso", "nos", "ayuda", "a", "mantener", "el", "enfoque", "y", "la", "disciplina.", "El", "desarrollo", "personal", "también", "implica", "el", "cultivo", "de", "habilidades", "sociales", "y", "emocionales.", "La", "empatía,", "la", "comunicación",    "efectiva", "y", "la", "resiliencia", "son", "aspectos", "importantes", "en", "las", "relaciones", "personales", "y", "el", "bienestar", "emocional.",    "En", "resumen,", "el", "desarrollo", "personal", "es", "un", "viaje", "constante", "de", "auto", "mejora", "y", "crecimiento.", "Al", "comprometerse", "con",    "este", "proceso,", "las", "personas", "pueden", "alcanzar", "una", "vida", "más", "satisfactoria", "y", "contribuir", "positivamente", "al", "mundo", "que",    "les", "rodea." };
                if (random > 0)
                {
                    for (i = DP.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = DP[i];
                        DP[i] = DP[j];
                        DP[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", DP);
            }
            else if (tematica == "Ciencia de Datos y Analítica")
            {
                string[] CDA = { "La", "ciencia", "de", "datos", "y", "analítica", "es", "un", "campo", "interdisciplinario", "que", "utiliza", "métodos", "científicos,", "procesos", "analíticos", "y", "tecnologías", "avanzadas", "para", "extraer", "conocimientos", "y", "comprensiones", "a", "partir", "de", "datos.", "Este", "campo", "se", "ha", "convertido", "en", "fundamental", "para", "la", "toma", "de", "decisiones", "y", "la", "innovación", "en", "diversas", "industrias.", "La", "ciencia", "de", "datos", "implica", "la", "captura,", "limpieza,", "análisis", "y", "visualización", "de", "grandes", "volúmenes", "de", "datos.", "Los", "científicos", "de", "datos", "utilizan", "técnicas", "estadísticas", "y", "algoritmos", "para", "identificar", "patrones", "y", "tendencias", "que", "pueden", "ser", "utilizados", "para", "tomar", "decisiones", "informadas.", "La", "analítica", "de", "datos", "va", "más", "allá", "de", "la", "descripción", "y", "exploración", "de", "datos,", "centrándose", "en", "predecir", "y", "optimizar", "resultados.", "Modelos", "predictivos", "y", "análisis", "avanzados", "permiten", "a", "las", "organizaciones", "anticipar", "tendencias", "y", "optimizar", "procesos", "de", "toma", "de", "decisiones.", "Las", "tecnologías", "como", "el", "aprendizaje", "automático", "y", "la", "inteligencia", "artificial", "juegan", "un", "papel", "clave", "en", "la", "evolución", "de", "la", "ciencia", "de", "datos.", "Estas", "herramientas", "permiten", "a", "los", "científicos", "de", "datos", "abordar", "problemas", "complejos", "y", "extraer", "conocimientos", "de", "conjuntos", "de", "datos", "cada", "vez", "más", "grandes", "y", "complejos.", "La", "ciencia", "de", "datos", "y", "analítica", "tienen", "aplicaciones", "en", "diversos", "sectores", "como", "finanzas,", "salud,", "marketing", "y", "tecnología.", "Ayudan", "a", "las", "organizaciones", "a", "optimizar", "operaciones,", "entender", "a", "los", "clientes", "y", "desarrollar", "innovaciones", "basadas", "en", "datos.", "En", "resumen,", "la", "ciencia", "de", "datos", "y", "analítica", "son", "herramientas", "poderosas", "que", "permiten", "a", "las", "organizaciones", "convertir", "datos", "en", "inteligencia", "y", "obtener", "ventajas", "competitivas", "en", "el", "entorno", "empresarial", "actual." };

                if (random > 0)
                {
                    for (i = CDA.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = CDA[i];
                        CDA[i] = CDA[j];
                        CDA[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", CDA);
            }
            else if (tematica == "Derechos Humanos y Justicia Social")
            {
                string[] DHJS = {"Los", "derechos", "humanos", "y", "la", "justicia", "social", "son", "principios", "fundamentales", "que", "buscan", "garantizar", "la", "dignidad", "y",    "la", "igualdad", "para", "todas", "las", "personas.", "Estos", "principios", "son", "esenciales", "para", "construir", "sociedades", "justas", "y",    "respetuosas", "de", "la", "diversidad.",    "Los", "derechos", "humanos", "son", "inherentes", "a", "todos", "los", "individuos,", "independientemente", "de", "su", "origen,", "género,", "religión",    "o", "cualquier", "otra", "característica.", "Incluyen", "derechos", "civiles,", "políticos,", "económicos,", "sociales", "y", "culturales,",   "y", "su", "protección", "es", "responsabilidad", "de", "los", "gobiernos", "y", "de", "la", "comunidad", "internacional.",    "La", "justicia", "social", "busca", "garantizar", "una", "distribución", "equitativa", "de", "los", "recursos", "y", "oportunidades", "en", "una",    "sociedad.", "Busca", "abordar", "las", "desigualdades", "y", "combatir", "la", "discriminación", "para", "lograr", "un", "bienestar", "colectivo.",    "La", "violación", "de", "los", "derechos", "humanos", "y", "las", "injusticias", "sociales", "son", "frecuentemente", "temas", "de", "preocupación",   "a", "nivel", "global.", "Organizaciones", "dedicadas", "a", "la", "defensa", "de", "los", "derechos", "humanos", "trabajan", "para", "garantizar",   "la", "protección", "de", "individuos", "vulnerables", "y", "fomentar", "la", "responsabilidad", "de", "los", "gobiernos", "y", "actores", "privados.",    "La", "promoción", "de", "la", "justicia", "social", "implica", "la", "creación", "de", "políticas", "y", "prácticas", "que", "eliminen", "las",   "barreras", "y", "promuevan", "la", "inclusión", "y", "la", "equidad.", "Aborda", "temas", "como", "la", "pobreza,", "la", "educación", "accesible",   "y", "la", "igualdad", "de", "oportunidades.",    "En", "resumen,", "los", "derechos", "humanos", "y", "la", "justicia", "social", "son", "pilares", "fundamentales", "para", "construir", "sociedades",    "justas", "y", "respetuosas", "de", "la", "diversidad.", "Su", "promoción", "y", "protección", "son", "responsabilidades", "compartidas", "que",    "requieren", "el", "compromiso", "de", "individuos,", "comunidades", "y", "gobiernos", "a", "nivel", "local", "e", "internacional."};
                if (random > 0)
                {
                    for (i = DHJS.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = DHJS[i];
                        DHJS[i] = DHJS[j];
                        DHJS[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", DHJS);
            }
            else if (tematica == "Noticias")
            {
                string[] N = {"Emoción", "en", "el", "mundo", "del", "deporte", "mientras", "se", "desarrollan", "eventos", "inéditos", "y", "sorprendentes.",    "En", "la", "última", "competición", "de", "fútbol,", "el", "equipo", "Bólidos", "Veloces", "sorprendió", "al", "anotar", "un", "gol",    "increíble", "desde", "la", "línea", "de", "esquina.", "El", "jugador", "hizo", "un", "lanzamiento", "curvado", "que", "dejó", "boquiabiertos",    "a", "rivales", "y", "aficionados.",    "En", "otra", "disciplina", "deportiva,", "el", "evento", "anual", "de", "carrera", "de", "cangrejos", "resultó", "en", "un", "empate",    "épico.", "Dos", "cangrejos", "cruzaron", "la", "línea", "de", "meta", "simultáneamente,", "generando", "debates", "sobre", "la", "justicia",    "en", "las", "competiciones", "de", "crustáceos.",    "Mientras", "tanto,", "la", "nueva", "estrella", "del", "skateboarding,", "conocida", "como", "El", "Vuelo", "Acrobático,", "asombró", "al",    "mundo", "con", "trucos", "nunca", "antes", "vistos.", "Realizó", "una", "serie", "de", "piruetas", "y", "saltos", "que", "dejaron", "a",    "la", "multitud", "atónita.",    "En", "una", "novedosa", "competición", "subacuática,", "los", "equipos", "de", "rugby", "acuático", "se", "desafiaron", "bajo", "el",    "agua,", "demostrando", "su", "destreza", "en", "un", "entorno", "inusual.", "Las", "imágenes", "subacuáticas", "capturaron", "la", "intensidad",    "del", "juego", "y", "la", "determinación", "de", "los", "jugadores.",    "Estos", "eventos", "deportivos", "inusuales", "han", "demostrado", "que", "el", "mundo", "del", "deporte", "siempre", "puede", "ofrecer",   "sorpresas", "y", "nuevas", "formas", "de", "entretenimiento.", "Los", "atletas", "se", "esfuerzan", "por", "superar", "los", "límites", "y",   "ofrecer", "a", "los", "fanáticos", "experiencias", "deportivas", "inolvidables.",    "En", "resumen,", "estos", "acontecimientos", "deportivos", "inusuales", "han", "agregado", "un", "toque", "extraordinario", "a", "las", "competiciones",  "y", "han", "dejado", "a", "los", "espectadores", "con", "la", "expectativa", "de", "más", "innovaciones", "y", "momentos", "memorables",  "en", "el", "fascinante", "mundo", "deportivo." };
                if (random > 0)
                {
                    for (i = N.Length -1; i > 0;i--)
                    {
                        j = randomwords.Next(0,i+ 1);
                        temp = N[i];
                        N[i] = N[j];
                        N[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", N);
            }
            else if (tematica == "Literatura")
            {
                string[] L = { "En", "el", "mundo", "de", "la", "literatura,", "nuevas", "historias", "florecen", "cada", "día,", "transportando", "a", "lectores",    "a", "mundos", "imaginarios", "y", "desafiando", "sus", "perspectivas.", "El", "autor", "Esteban", "Aventuras", "ha", "lanzado",    "su", "última", "obra,", "una", "novela", "épica", "que", "explora", "las", "profundidades", "del", "alma", "humana.",    "Mientras", "tanto,", "en", "el", "género", "de", "ciencia", "ficción,", "la", "escritora", "Galaxia", "Estelar", "ha", "creado",    "un", "universo", "completamente", "nuevo", "donde", "las", "máquinas", "y", "los", "humanos", "coexisten", "de", "manera",    "inesperada.", "Su", "prosa", "futurista", "ha", "capturado", "la", "imaginación", "de", "lectores", "y", "críticos", "por",    "igual.",    "En", "el", "género", "de", "poesía,", "la", "poeta", "Luna", "Cautiva", "ha", "lanzado", "una", "colección", "de", "versos",   "que", "exploran", "las", "emociones", "humanas", "en", "sus", "formas", "más", "intensas.", "Sus", "palabras", "tejen",  "un", "tapiz", "de", "sentimientos", "que", "resonan", "en", "el", "corazón", "de", "quienes", "se", "sumergen", "en",  "sus", "páginas.",  "Por", "otro", "lado,", "el", "autor", "de", "misterio", "Noche", "Intrigante", "ha", "lanzado", "su", "último", "thriller,",  "llenando", "las", "páginas", "con", "intriga", "y", "suspenso.", "Los", "lectores", "se", "ven", "arrastrados", "a", "un", "viaje", "oscuro", "donde", "nada", "es", "lo", "que", "parece.", "En", "resumen,", "el", "mundo", "de", "la", "literatura", "continúa", "evolucionando", "con", "nuevos", "talentos", "y", "nuevas", "historias", "que", "invitan", "a", "lectores", "a", "explorar", "nuevos", "mundos", "y", "experimentar", "nuevas", "emociones.", "Los", "escritores", "siguen", "siendo", "los", "artesanos", "de", "la", "imaginación,", "dando", "vida", "a", "personajes", "inolvidables", "y", "tejiendo", "narrativas", "que", "resonarán", "a", "través", "de", "las", "eras."};
                if (random > 0)
                {
                    for (i = L.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = L[i];
                        L[i] = L[j];
                        L[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", L);
            }
            else if (tematica == "Programacion")
            {
                string[] P = {"En", "el", "fascinante", "mundo", "de", "la", "programación,", "los", "desarrolladores", "se", "embarcan", "en", "viajes",    "al", "reino", "de", "los", "algoritmos", "y", "la", "lógica", "de", "código.", "El", "ingeniero", "Byte", "Creador", "ha",    "lanzado", "una", "nueva", "biblioteca", "de", "funciones", "que", "simplifican", "tareas", "complejas", "y", "optimizan", "el",    "rendimiento", "del", "software.",    "En", "el", "mundo", "del", "desarrollo", "web,", "la", "diseñadora", "de", "interfaces", "Pixel", "Artística", "ha", "creado",  "un", "conjunto", "de", "estilos", "CSS", "innovadores", "que", "transforman", "las", "páginas", "web", "en", "obras", "de",  "arte", "visual.", "Sus", "técnicas", "de", "diseño", "prometen", "una", "experiencia", "de", "usuario", "única.",  "Por", "otro", "lado,", "el", "científico", "de", "datos", "Quantum", "Analítico", "ha", "lanzado", "un", "conjunto", "de",  "algoritmos", "de", "aprendizaje", "profundo", "que", "abordan", "problemas", "complejos", "en", "el", "análisis", "de", "datos.",   "Sus", "innovadoras", "técnicas", "permiten", "a", "los", "analistas", "extraer", "información", "valiosa", "de", "conjuntos", "masivos", "de", "datos.",  "En", "el", "ámbito", "de", "la", "seguridad", "informática,", "el", "hacker", "Éter", "Codificador", "ha", "lanzado", "un", "conjunto", "de", "herramientas", "de", "penetración", "que", "ponen", "a", "prueba", "la", "resiliencia", "de", "los", "sistemas",   "y", "mejoran", "las", "defensas", "contra", "ciberataques.",  "En", "resumen,", "la", "programación", "sigue", "siendo", "un", "campo", "dinámico", "y", "vibrante,", "donde", "los", "desarrolladores",  "continúan", "innovando", "y", "creando", "soluciones", "nuevas", "que", "impulsan", "la", "tecnología", "hacia", "el", "futuro." };
                if (random > 0)
                {
                    for (i = P.Length - 1; i > 0; i--)
                    {
                        j = randomwords.Next(0, i + 1);
                        temp = P[i];
                        P[i] = P[j];
                        P[j] = temp;
                    }
                }
                txtpalabrasmostradas.Text = string.Join(" ", P);
            }
        }

        private void verificar_palabras()
        {
            List<string> palabras = new List<string>(txtpalabrasmostradas.Text.Trim().Split(' '));
            string palabra_mostrada = palabras[0],
            palabra_escrita = txtpalabrasescritas.Text.Trim();

            if (palabra_escrita.Length == palabra_mostrada.Length || palabra_escrita.Length != palabra_mostrada.Length)
            {
                if (palabra_escrita == palabra_mostrada)
                {
                    correctas++;
                }
                else
                {
                    incorrectas++;
                }

                pcompletadas++;
                palabras.RemoveAt(0);
                txtpalabrasmostradas.Text = string.Join(" ", palabras);
            }
        }

        private void txtpalabrasescritas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = h.goodtyped(e) ? false : true;
        }

        private void cargarfrm()
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            this.Text = "Tematicas: " + esc.usuario_sesion;
            listar_palabras();
            btnreiniciar.Enabled = false;
            txtpalabrasescritas.Enabled = false;
        }

        private void FrmTematicasV_Load(object sender, EventArgs e)
        {
            cargarfrm();
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (CMBtematicas.Text.Length != 0)
            {
                btnIniciar.Enabled = false;
                btnreiniciar.Enabled = false;
                txtpalabrasescritas.Enabled = true;
                txtpalabrasescritas.Focus();
                txtpalabrasescritas.Clear();
                correctas = 0;
                incorrectas = 0;
                pcompletadas = 0;
                lvPalabras.Items.Clear();
                CMBtematicas.Enabled = false;
                RELOJ.Start();
            }
            else
            {
                h.Warning("Seleccione una Tematica");
            }
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea que la tematica sea aleatoria?";
            if (h.Question(msg) == true) { listar_palabras(CMBtematicas.Text, 1); lblSEGUNDOS.Text = "60"; btnreiniciar.Enabled = false; txtpalabrasescritas.Enabled = true; txtpalabrasescritas.Focus(); RELOJ.Start(); txtpalabrasescritas.Clear(); correctas = 0; incorrectas = 0; pcompletadas = 0; CMBtematicas.Enabled = false; }
            else { lblSEGUNDOS.Text = "60"; btnreiniciar.Enabled = false; txtpalabrasescritas.Enabled = true; txtpalabrasescritas.Focus(); RELOJ.Start(); txtpalabrasescritas.Clear(); correctas = 0; incorrectas = 0; pcompletadas = 0; listar_palabras(CMBtematicas.Text); CMBtematicas.Enabled = false; }
        }

        private void txtpalabrasescritas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                WrongLetterPosition();
                SkippedLetters();
                LetterAddedWrongly();
                verificar_palabras();
                txtpalabrasescritas.Clear();
            }
        }

        private void RELOJ_Tick(object sender, EventArgs e)
        {
            int conteo = Convert.ToInt32(lblSEGUNDOS.Text);
            conteo--;
            lblSEGUNDOS.Text = conteo.ToString();
            if (conteo == 0)
            {
                RELOJ.Stop();
                MessageBox.Show("!Se ha agotado el tiempo!");

                ListViewItem item = item = lvPalabras.Items.Add(pcompletadas.ToString());
                item.SubItems.Add(correctas.ToString());
                item.SubItems.Add(incorrectas.ToString());
                item.SubItems.Add(Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%");
                item.SubItems.Add(L_omitidas.ToString());
                item.SubItems.Add(L_PosM.ToString());
                item.SubItems.Add(L_added.ToString());

                txtpalabrasescritas.Clear();
                lblSEGUNDOS.Text = "60";
                btnIniciar.Enabled = false;
                btnreiniciar.Enabled = true;
                txtpalabrasescritas.Enabled = false;
                CMBtematicas.Enabled = true;

                string ppm = "", pc = "", pi = "", Lomitida = "", LPosM = "", LAddedM = "";
                foreach (ListViewItem datosLV in lvPalabras.Items)
                {
                    ppm = datosLV.SubItems[0].Text;
                    pc = datosLV.SubItems[1].Text;
                    pi = datosLV.SubItems[2].Text;
                    Lomitida = datosLV.SubItems[4].Text;
                    LPosM = datosLV.SubItems[5].Text;
                    LAddedM = datosLV.SubItems[6].Text;
                }

                mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
                esc = ((mecanografia.ESCRITURA)Owner);

                if (esc.usuario_sesion != "")
                {
                    if (CMBtematicas.Text == "Ciencia y Tecnología")                            DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Cultura y Entretenimiento")                  DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Ciencias Sociales")                          DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Historia y Eventos Actuales")                DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Salud y Bienestar ")                         DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Medio Ambiente")                             DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Educación")                                  DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Tendencias en Estilo de Vida")               DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Viajes y Culturas")                          DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Exploración Espacial")                       DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "misiones espaciales y descubrimientos")      DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Tecnologías Emergentes")                     DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Realidad virtual")                           DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Blockchain y criptomonedas")                 DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Desarrollos en robótica y automatización")   DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Psicología y Bienestar Mental")              DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Nutrición y Alimentación")                   DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Innovación Empresarial")                     DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Arquitectura y Diseño Urbano")               DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Deportes y Rendimiento Físico")              DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Arqueología y Descubrimientos Históricos")   DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Desarrollo Personal")                        DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Ciencia de Datos y Analítica")               DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Derechos Humanos y Justicia Social")         DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Noticias")                                   DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Literatura")                                 DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    else if (CMBtematicas.Text == "Programacion")                               DB.guardar("TEMA", "USUARIO,TEMA,PPM,C,I,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{esc.usuario_sesion}','{CMBtematicas.Text}','{ppm}','{pc}','{pi}','{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                }
            }
        }

        private void CMBdificultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg = "¿Desea que la tematica sea aleatoria?";
            if (h.Question(msg) == true) { listar_palabras(CMBtematicas.Text, 1); btnIniciar.Enabled = true; btnreiniciar.Enabled = false; }
            else listar_palabras(CMBtematicas.Text);
        }
    }
}

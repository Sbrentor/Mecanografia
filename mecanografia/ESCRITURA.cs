using MECANOGRAFIA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MECANOGRAFIA.mecanografia
{
    public partial class ESCRITURA : Form
    {
        clases.db DB = new clases.db();
        clases.helpers h = new clases.helpers();
        clases.ENV env = new clases.ENV();
        clases.auth a = new clases.auth();
        int correctas = 0, incorrectas = 0, pcompletadas = 0, L_omitidas = 0, L_PosM = 0, L_added = 0, i, j, dias_seguido = 0;
        public string usuario_sesion = "";
        string tabla, campos, valores, condicion, msg, p, p_escrita;

        public ESCRITURA()
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

        private void lista_palabras()
        {
            string[] words = { "casa", "perro", "gato", "sol", "luna", "árbol", "flor", "mesa", "silla", "coche", "amarillo", "rojo", "verde", "azul", "feliz", "triste", "amor", "odio", "jugar", "correr", "comer", "dormir", "agua", "fuego", "nieve", "tierra", "aire", "soltero", "casado", "niño", "niña", "escuela", "libro", "maestro", "estudiante", "cielo", "nube", "montaña", "río", "mar", "lago", "ciudad", "país", "musica", "baile", "pintura", "dibujo", "pelota", "juego", "risa", "llanto", "familia", "amigo", "hermano", "hermana", "padre", "madre", "abuelo", "abuela", "comida", "bebida", "manzana", "naranja", "banana", "uva", "pollo", "pescado", "carne", "vegetal", "fruta", "computadora", "teléfono", "internet", "television", "radio", "calle", "avenida", "parque", "bosque", "camino", "viaje", "avión", "tren", "autobús", "bicicleta", "caminar", "correr", "nadar", "viajar", "trabajo", "dinero", "compra", "venta", "mercado", "tienda", "ropa", "zapatos", "camisa", "película", "teatro", "arte", "historia", "ciencia", "idioma", "palabra", "frase", "párrafo", "número", "letra", "color", "forma", "tamaño", "peso", "altura", "ancho", "largo", "corto", "rápido", "lento", "fuerte", "débil", "alto", "bajo", "grande", "pequeño", "nuevo", "viejo", "bueno", "malo", "amable", "cruel", "feliz", "triste", "fácil", "difícil", "claro", "oscuro", "caliente", "frío", "rico", "pobre", "limpio", "sucio", "salud", "paz", "guerra", "educación", "trabajador", "dormitorio", "peluche", "lápiz", "nube", "teléfono", "silla", "bicicleta", "deporte", "reloj", "calendario", "periódico", "ventana", "puerta", "llave", "candado", "jardín", "mañana", "tarde", "noche", "verano", "invierno", "otoño", "relación", "romance", "teclado", "mouse", "pantalla", "luz", "energía", "gas", "aire", "respirar", "sonrisa", "dentista", "cabello", "cepillo", "espejo", "perfume", "música", "radio", "melodía", "piano", "violín", "juego", "carta", "dado", "moneda", "billete", "cambio", "comida", "bebida", "cuchillo", "tenedor", "cuchara", "plato", "vaso", "taza", "cena", "almuerzo", "desayuno", "bolsa", "zapatos", "botas", "sombrero", "gorro", "bufanda", "guantes", "abrigo", "falda", "camiseta", "calcetines", "zapatillas", "cine", "película", "escena", "actor", "actriz", "director", "guion", "cámara", "fotografía", "pintura", "lienzo", "colores", "pincel", "forma", "espacio", "tiempo", "reloj", "arena", "océano", "isla", "costa", "montaña", "valle", "cima", "abismo", "pasaporte", "frontera", "viaje", "turista", "hotel", "cama", "almohada", "cobija", "sueño", "pesadilla", "vuelo", "aeropuerto", "boleto", "avión", "autobús", "tren", "estación", "automóvil", "bicicleta", "caminata", "excursión", "aventura", "explorar", "descubrir", "viaje", "destino", "mapa", "brújula", "norte", "sur", "este", "oeste", "flecha", "señal", "tráfico", "peatón", "vehículo", "carretera", "calle", "avenida", "trabajo", "oficina", "jefe", "empleado", "colega", "negocio", "éxito", "fracaso", "metas", "logro", "proyecto", "equipo", "reunión", "cliente", "producto", "servicio", "venta", "sol", "luna", "cielo", "mar", "montaña", "árbol", "flor", "río", "nieve", "viento", "animal", "perro", "gato", "pez", "pájaro", "oso", "casa", "calle", "coche", "bicicleta", "comida", "manzana", "pan", "queso", "leche", "agua", "carne", "fruta", "verdura", "arroz", "juego", "pelota", "muñeca", "juguete", "canción", "música", "baile", "libro", "letra", "número", "color", "rojo", "azul", "verde", "amarillo", "blanco", "negro", "gris", "naranja", "rosa", "día", "noche", "hora", "minuto", "segundo", "mes", "año", "ayer", "hoy", "mañana", "feliz", "triste", "enojado", "asustado", "sorpresa", "contento", "aburrido", "cansado", "dormir", "despertar", "trabajo", "estudio", "escuela", "maestro", "alumno", "clase", "proyecto", "tarea", "examen", "respuesta", "deporte", "fútbol", "baloncesto", "natación", "carrera", "ejercicio", "salud", "medicina", "doctor", "hospital", "ropa", "camisa", "pantalón", "zapatos", "sombrero", "chaqueta", "abrigo", "vestido", "calcetines", "ropa", "interior", "calzado", "tecnología", "teléfono", "computadora", "internet", "aplicación", "mensaje", "correo", "redes", " sociales", "cámara", "pantalla", "viaje", "avión", "coche", "tren", "barco", "hotel", "vacaciones", "turista", "mapa", "guía", "familia", "padre", "madre", "hermano", "hermana", "abuelo", "abuela", "hijo", "hija", "niño", "niña", "cariño", "amigo", "amiga", "amor", "beso", "abrazo", "risa", "llanto", "fiesta", "regalo", "podemos", "entonces", "cosas", "años", "porque", "sin", "un", "ella", "porque", "estas", "me", "hasta", "yo", "tiempo" };

            Random randomwords = new Random();
            for (int i = words.Length - 1; i > 0; i--)
            {
                int j = randomwords.Next(0, i + 1);
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }
            txtpalabrasmostradas.Text = string.Join(" ", words);
        }

        private void verificar_palabras()
        {
            List<string> palabras = new List<string>(txtpalabrasmostradas.Text.Trim().Split(' '));
            string palabra_mostrada = palabras[0],
            palabra_escrita = txtpalabrasescritas.Text.Trim();

            if (palabra_escrita.Length == palabra_mostrada.Length || palabra_escrita.Length != palabra_mostrada.Length)
            {
                if (palabra_escrita == palabra_mostrada) correctas++;
                else incorrectas++;

                pcompletadas++;
                palabras.RemoveAt(0);
                txtpalabrasmostradas.Text = string.Join(" ", palabras);
            }
        }

        private int validar_sesion()
        {
            int res = 0;
            if (txtusuario_sesion.Text.Length == 0 && CBusuario.Text.Length == 0)
            {
                h.Warning("el usuario es obligatorio");
                txtusuario.Focus();
                res++;
            }
            else if (txtcontra_sesion.Text.Length == 0 && txtusuario_sesion.Text.Length == 0)
            {
                h.Warning("la contraseña es obligatoria y usuario son obligatorios");
                txtcontra.Focus();
                res++;
            }
            return res;
        }

        private int validar_registro()
        {
            int res = 0;
            if (txtcontra.Text.Length == 0)
            {
                h.Warning("la contraseña es obligatoria");
                txtcontra.Focus();
                res++;
            }
            else if (txtusuario.Text.Length == 0)
            {
                h.Warning("el usuario es obligatorio");
                txtusuario.Focus();
                res++;
            }

            return res;
        }

        private void cargarformulario()
        {
            this.Size = new Size(628, 381);
            this.P_ESCRITURA.Location = new Point(3, 3);
            P_ESCRITURA.Size = new Size(602, 296);
            this.Text = env.APPNAME;
            lista_palabras();
            txtpalabrasescritas.Enabled = false;
            btnreiniciar.Enabled = false;
            P_REGISTRO.Visible = false;
            P_INICIOSESION.Visible = false;
            txtpalabrasmostradas.Enabled = false;
            RDno.Checked = true;
        }

        private void cambiarmodos()
        {
            if (P_OFF.BackColor == Color.Red)
            {
                P_ON.BackColor = Color.Green;
                P_OFF.BackColor = Color.Gray;

                lblSEGUNDOS.BackColor = Color.Black;
                lblSEGUNDOS.ForeColor = Color.White;
                lblINCIAR_SESION.BackColor = Color.Black;
                lblINCIAR_SESION.ForeColor = Color.White;
                lbl1.BackColor = Color.Black;
                lbl1.ForeColor = Color.White;
                lbl3.BackColor = Color.Black;
                lbl3.ForeColor = Color.White;
                lbl4.BackColor = Color.Black;
                lbl4.ForeColor = Color.White;
                lbl5.BackColor = Color.Black;
                lbl5.ForeColor = Color.White;
                lbl6.BackColor = Color.Black;
                lbl6.ForeColor = Color.White;

                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;

                btnIniciar.BackColor = Color.White;
                btnIniciar.ForeColor = Color.Black;
                btnreiniciar.BackColor = Color.White;
                btnreiniciar.ForeColor = Color.Black;

                btncancelar.BackColor = Color.Black;
                btncancelar.ForeColor = Color.White;
                btnentrar_REGISTRO.BackColor = Color.Black;
                btnentrar_REGISTRO.ForeColor = Color.White;
                btnentrar_INCIOSESION.BackColor = Color.Black;
                btnentrar_INCIOSESION.ForeColor = Color.White;
                btncancelar_sesion.BackColor = Color.Black;
                btncancelar_sesion.ForeColor = Color.White;
                btnver.BackColor = Color.Black;
                btnver.ForeColor = Color.White;
                btnverSesion.BackColor = Color.Black;
                btnverSesion.ForeColor = Color.White;
                btnVolverAEscritura.BackColor = Color.Black;
                btnVolverAEscritura.ForeColor = Color.White;
                btnVolverASesion.BackColor = Color.Black;
                btnVolverASesion.ForeColor = Color.White;
                foreach (TextBox txt in this.Controls.OfType<TextBox>()) { txt.BackColor = Color.Black; txt.ForeColor = Color.White; }
                lvPalabras.BackColor = Color.Black; lvPalabras.ForeColor = Color.Black;
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;

                lblINCIAR_SESION.ForeColor = Color.Blue;
                lblINCIAR_SESION.BackColor = Color.White;
                MenuOpciones.ForeColor = Color.Black;

            }
            else if (P_ON.BackColor == Color.Green)
            {
                P_ON.BackColor = Color.Gray;
                P_OFF.BackColor = Color.Red;

                lblSEGUNDOS.BackColor = Color.White;
                lblSEGUNDOS.ForeColor = Color.Black;
                lblINCIAR_SESION.BackColor = Color.White;
                lblINCIAR_SESION.ForeColor = Color.Blue;
                lbl1.BackColor = Color.White;
                lbl1.ForeColor = Color.Black;
                lbl3.BackColor = Color.White;
                lbl3.ForeColor = Color.Black;
                lbl4.BackColor = Color.White;
                lbl4.ForeColor = Color.Black;
                lbl5.BackColor = Color.White;
                lbl5.ForeColor = Color.Black;
                lbl6.BackColor = Color.White;
                lbl6.ForeColor = Color.Black;

                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;

                btnIniciar.BackColor = Color.White;
                btnIniciar.ForeColor = Color.Black;
                btnreiniciar.BackColor = Color.White;
                btnreiniciar.ForeColor = Color.Black;
                btncancelar.BackColor = Color.White;
                btncancelar.ForeColor = Color.Black;
                btnentrar_REGISTRO.BackColor = Color.White;
                btnentrar_REGISTRO.ForeColor = Color.Black;
                btnentrar_INCIOSESION.BackColor = Color.White;
                btnentrar_INCIOSESION.ForeColor = Color.Black;
                btncancelar_sesion.BackColor = Color.White;
                btncancelar_sesion.ForeColor = Color.Black;
                btnver.BackColor = Color.White;
                btnver.ForeColor = Color.Black;
                btnverSesion.BackColor = Color.White;
                btnverSesion.ForeColor = Color.Black;
                btnVolverAEscritura.BackColor = Color.White;
                btnVolverAEscritura.ForeColor = Color.Black;
                btnVolverASesion.BackColor = Color.White;
                btnVolverASesion.ForeColor = Color.Black;

                foreach (TextBox txt in this.Controls.OfType<TextBox>()) { txt.BackColor = Color.White; txt.ForeColor = Color.Black; }
                lvPalabras.BackColor = Color.White; lvPalabras.ForeColor = Color.Black;
                this.BackColor = Color.CadetBlue;
                this.ForeColor = Color.Black;

                lblINCIAR_SESION.ForeColor = Color.Blue;
            }
        }

        private void ESCRITURA_Load(object sender, EventArgs e)
        {
            cargarformulario();
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
                if (usuario_sesion == "") btnIniciar.Enabled = true;
                else
                {
                    btnIniciar.Enabled = false;
                    btnreiniciar.Enabled = true;
                }
                txtpalabrasescritas.Enabled = false;
                lblINCIAR_SESION.Enabled = true;
                MenuOpciones.Enabled = true;

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

                if (usuario_sesion != "")
                {
                    DB.guardar("RECORDS_USUARIOS", "USUARIO,PALABRAS_POR_MINUTO,PALABRAS_CORRECTAS,PALABRAS_INCORRECTAS,PRECISION,L_O,L_POS_M,L_ADDED_M", $"'{usuario_sesion}','{ppm}','{pc}','{pi}','{Convert.ToDouble(Math.Round(((float)correctas / pcompletadas) * 100, 3)) + "%"}','{Lomitida}','{LPosM}','{LAddedM}'");
                    registry_achievments(ppm);
                    registry_achievments_C(pc);
                }
            }
        }

        private void registry_achievments_C(string pc)
        {
            DataTable datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 10 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 10) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{10}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 20 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 20) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{20}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 30 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 30) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{30}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 40 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 40) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{40}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 50 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 50) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{50}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 60 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 60) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{60}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 70 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 70) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{70}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 80 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 80) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{80}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 90 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 90) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{90}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 100 AND LOGRO = 'PC' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(pc) >= 100) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PC',{100}");
        }

        private void registry_achievments(string ppm)
        {
            DataTable datos = DB.recuperar("LOGROS_USUARIOS","*",$"CANT = 10 AND LOGRO = 'PPM' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 10) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{10}");
            
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 20 AND LOGRO = 'PPM'  AND USUARIO =  '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 20) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{20}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 30 AND LOGRO = 'PPM'  AND USUARIO =  '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 30) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{30}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 40 AND LOGRO = 'PPM'  AND USUARIO =  '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 40) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{40}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 50 AND LOGRO = 'PPM'  AND USUARIO =  '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 50) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{50}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 60 AND LOGRO = 'PPM'  AND USUARIO =  '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 60) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{60}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 70 AND LOGRO = 'PPM'  AND USUARIO =  '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 70) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{70}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 80 AND LOGRO = 'PPM'  AND USUARIO =  '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 80) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{80}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 90 AND LOGRO = 'PPM' AND USUARIO =  '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 90) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{90}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 100 AND LOGRO = 'PPM' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 100) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{100}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 120 AND LOGRO = 'PPM' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 120) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{120}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 140 AND LOGRO = 'PPM' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 140) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{140}");
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"CANT = 150 AND LOGRO = 'PPM' AND USUARIO = '{usuario_sesion}'");
            if (datos.Rows.Count == 0) if (Convert.ToInt32(ppm) >= 150) DB.guardar("LOGROS_USUARIOS", "USUARIO,LOGRO,CANT", $"'{usuario_sesion}','PPM',{150}");

        }

        private void lblINCIAR_SESION_Click(object sender, EventArgs e)
        {
            DataTable datos = DB.recuperar("USUARIOS", "*");
            if (usuario_sesion == "")
            {
                P_ESCRITURA.Visible = false;
                P_INICIOSESION.Visible = true;
                lvPalabras.Items.Clear();
                this.Text = " INICIO DE SESION ";
                MenuOpciones.Enabled = false;

                P_INICIOSESION.Size = new Size(324, 244);
                CBusuario.Visible = false;
                P_INICIOSESION.Location = new Point(-0, -2);
                this.Size = new Size(340, 320);
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                if (datos.Rows.Count > 0) { RDno.Enabled = true; RDsi.Enabled = true; }
                else { RDno.Enabled = false; RDsi.Enabled = false; }
            }
            else
            {
                msg = "¿Desea Cerrar Sesion?";
                if (h.Question(msg) == true)
                {
                    usuario_sesion = "";
                    lvPalabras.Items.Clear();
                    P_ESCRITURA.Visible = false;
                    P_INICIOSESION.Visible = true;
                    this.Text = " INICIO DE SESION ";
                    MenuOpciones.Enabled = false;
                    btnreiniciar.Enabled = false;
                    btnIniciar.Enabled = true;

                    P_INICIOSESION.Size = new Size(324, 244);
                    CBusuario.Visible = false;
                    P_INICIOSESION.Location = new Point(-0, -2);
                    this.Size = new Size(340, 320);
                    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    if (datos.Rows.Count > 0) { RDno.Enabled = true; RDsi.Enabled = true; }
                    else { RDno.Enabled = false; RDsi.Enabled = false; }
                }
            }
        }

        private void iniciar()
        {
            MenuOpciones.Enabled = false;
            btnIniciar.Enabled = false;
            btnreiniciar.Enabled = false;
            txtpalabrasescritas.Enabled = true;
            txtpalabrasmostradas.Enabled = true;
            txtpalabrasescritas.Focus();
            txtpalabrasescritas.Clear();
            correctas = 0;incorrectas = 0;pcompletadas = 0;L_omitidas = 0; L_PosM = 0; L_added = 0;
            lvPalabras.Items.Clear();
            lblINCIAR_SESION.Enabled = false;
            lblINCIAR_SESION.BackColor = Color.White;
            RELOJ.Start();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void btnentrar_REGISTRO_Click(object sender, EventArgs e)
        {
            if (validar_registro() == 0)
            {
                tabla = "USUARIOS";
                campos = $"USUARIO,NAME_PC,CONTRA";
                valores = $"'{h.CleanSQL(txtusuario.Text.Trim())}','{Dns.GetHostName()}','{a.MakeHash(txtcontra.Text)}'";
                condicion = $"USUARIO = '{txtusuario.Text.Trim()}'";
                DataTable datos = DB.recuperar(tabla, "*", condicion);

                if (datos.Rows.Count > 0)
                {
                    h.Warning("El usuario " + txtusuario.Text.Trim() + " ya existe ingrese otro");
                    txtusuario.Focus();
                }
                else
                {
                    if (DB.guardar(tabla, campos, valores) > 0)
                    {
                        h.Succes("Se ha registrado con exito");
                        MenuOpciones.Enabled = true;
                        usuario_sesion = txtusuario.Text;

                        DataTable d = DB.recuperar("RACHA_USUARIOS_DS", "*", $"USUARIO = '{usuario_sesion}'");
                        if (d.Rows.Count == 0)
                        {
                            dias_seguido++;
                            DB.guardar("RACHA_USUARIOS_DS", "USUARIO,DIAS_S", $"'{usuario_sesion}','{dias_seguido}'");
                        }
                        d.Dispose();

                        this.Text = env.APPNAME + txtusuario.Text;
                        lvPalabras.Items.Clear();
                        P_REGISTRO.Visible = false;
                        P_ESCRITURA.Visible = true;
                        txtcontra.Clear();
                        txtusuario.Clear();

                        this.Size = new Size(628, 381);
                        MenuOpciones.Visible = true;
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    }
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontra.Clear();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            txtcontra.UseSystemPasswordChar = txtcontra.UseSystemPasswordChar ? false : true;
        }

        private void btnentrar_INCIOSESION_Click(object sender, EventArgs e)
        {
            if (validar_sesion() == 0)
            {
                string usuario = h.CleanSQL(txtusuario_sesion.Text), usuariocmb = CBusuario.Text, contra = a.MakeHash(txtcontra_sesion.Text)
                , condicion = $"USUARIO = '{usuario}' AND CONTRA = '{contra}' OR USUARIO = '{usuariocmb}' AND CONTRA = '{contra}'";

                DataTable datos = DB.recuperar("USUARIOS", "USUARIO,CONTRA", condicion);
                if (datos.Rows.Count > 0)
                {
                    DataRow r = datos.Rows[0];
                    string user2 = r["USUARIO"].ToString(), contra2 = r["CONTRA"].ToString();
                    if (usuario == user2 && contra == contra2 || usuariocmb == user2 && contra == contra2)
                    {
                        h.Succes("Ha inciado sesion con exito");

                        MenuOpciones.Enabled = true;

                        if (CBusuario.Text.Length == 0)
                        {
                            this.Text = env.APPNAME + txtusuario_sesion.Text;
                            usuario_sesion = txtusuario_sesion.Text;
                        }
                        else if (txtusuario_sesion.Text.Length == 0)
                        {
                            this.Text = env.APPNAME + CBusuario.Text;
                            usuario_sesion = CBusuario.Text;
                        }

                        if (usuario_sesion != "")
                        {
                            DataTable d_seguidos = DB.recuperar("RACHA_USUARIOS_DS", "*", $"USUARIO = '{usuario_sesion}'");
                            if (d_seguidos.Rows.Count > 0)
                            {
                                DateTime fec_registro_usuario;
                                int fec = DateTime.Today.Day;
                                foreach (DataRow row in d_seguidos.Rows)
                                {
                                    fec_registro_usuario = Convert.ToDateTime(row["FECHA"]);
                                    dias_seguido = Convert.ToInt32(row["DIAS_S"]);
                                    if (fec_registro_usuario.Date.Day == fec) break;
                                    else if (fec_registro_usuario.Day + 2 == fec || fec_registro_usuario.Day + 3 == fec || fec_registro_usuario.Day + 4 == fec || fec_registro_usuario.Day + 5 == fec
                                           || fec_registro_usuario.Day + 6 == fec || fec_registro_usuario.Day + 7 == fec || fec_registro_usuario.Day + 8 == fec || fec_registro_usuario.Day + 9 == fec || fec_registro_usuario.Day + 10 == fec
                                           || fec_registro_usuario.Day + 11 == fec || fec_registro_usuario.Day + 12 == fec || fec_registro_usuario.Day + 13 == fec || fec_registro_usuario.Day + 14 == fec || fec_registro_usuario.Day + 15 == fec
                                           || fec_registro_usuario.Day + 16 == fec || fec_registro_usuario.Day + 17 == fec || fec_registro_usuario.Day + 18 == fec || fec_registro_usuario.Day + 19 == fec || fec_registro_usuario.Day + 20 == fec
                                           || fec_registro_usuario.Day + 21 == fec || fec_registro_usuario.Day + 22 == fec || fec_registro_usuario.Day + 23 == fec || fec_registro_usuario.Day + 24 == fec || fec_registro_usuario.Day + 25 == fec
                                           || fec_registro_usuario.Day + 26 == fec || fec_registro_usuario.Day + 27 == fec || fec_registro_usuario.Day + 28 == fec || fec_registro_usuario.Day + 29 == fec || fec_registro_usuario.Day + 30 == fec)
                                    {
                                        dias_seguido = 0;
                                        DB.actualizar("RACHA_USUARIOS_DS", $"DIAS_S = '{dias_seguido}',FECHA = '{DateTime.Today}'", $"USUARIO = '{usuario_sesion}'");
                                        h.Info($"Tu racha se acabado");
                                    }
                                    else if (fec_registro_usuario.Date.Day < fec || fec_registro_usuario.Date.Day > fec)
                                    {
                                        dias_seguido++;
                                        DB.actualizar("RACHA_USUARIOS_DS", $"DIAS_S = '{dias_seguido}',FECHA = '{DateTime.Today}'", $"USUARIO = '{usuario_sesion}'");
                                        h.Info($"! Tienes una racha de {dias_seguido} días seguidos ¡");
                                    }
                                }
                            }
                            d_seguidos.Dispose();
                        }

                        RDsi.Checked = false;
                        lvPalabras.Items.Clear();
                        P_ESCRITURA.Visible = true;
                        P_INICIOSESION.Visible = false;
                        txtusuario_sesion.Clear();
                        txtcontra_sesion.Clear();

                        this.Size = new Size(628, 381);
                        MenuOpciones.Visible = true;
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    }
                    else
                    {
                        h.Warning("Usuario y/o contraseña son incorrectas");
                        txtusuario_sesion.Focus();
                    }
                }
                else
                {
                    h.Warning("el Usuario y/o contraña son incorrectas");
                    txtusuario_sesion.Focus();
                }
            }
        }

        private void btnverSesion_Click(object sender, EventArgs e)
        {
            txtcontra_sesion.UseSystemPasswordChar = txtcontra_sesion.UseSystemPasswordChar ? false : true;
        }

        private void btncancelar_sesion_Click(object sender, EventArgs e)
        {
            txtusuario_sesion.Clear();
            txtcontra_sesion.Clear();
        }

        private void registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Text = "   REGISTRARSE";
            P_INICIOSESION.Visible = false;
            P_REGISTRO.Visible = true;

            P_REGISTRO.Size = new Size(230, 164);
            P_REGISTRO.Location = new Point(-5, -4);
            this.Size = new Size(240, 250);
        }

        private void OPTlogros_Click(object sender, EventArgs e)
        {
            mecanografia.LOGROS.FrmLogrosGeneral L = new mecanografia.LOGROS.FrmLogrosGeneral();
            this.AddOwnedForm(L);
            L.ShowDialog();
        }

        private void mODOPERSONALIZADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mecanografia.DESAFIOS.FrmPersonalizado per = new mecanografia.DESAFIOS.FrmPersonalizado();
            this.AddOwnedForm(per);
            per.ShowDialog();
        }

        private void txtpalabrasescritas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = h.Onlystrings(e) ? false : true;
        }

        private void btnVolverASesion_Click(object sender, EventArgs e)
        {
            this.Text = " INICIO DE SESION ";
            P_REGISTRO.Visible = false;
            P_INICIOSESION.Visible = true;
            P_INICIOSESION.Size = new Size(324, 244);
            P_INICIOSESION.Location = new Point(-0, -2);
            this.Size = new Size(340, 320);
            txtusuario.Clear();
            txtcontra.Clear();
        }

        private void btnVolverAEscritura_Click(object sender, EventArgs e)
        {
            MenuOpciones.Enabled = true;
            this.Text = env.APPNAME + usuario_sesion;
            MenuOpciones.Visible = true;
            P_INICIOSESION.Visible = false;
            P_ESCRITURA.Visible = true;
            txtusuario_sesion.Clear();
            txtcontra_sesion.Clear();
            RDsi.Checked = false;
            RDno.Checked = true;

            this.Size = new Size(628, 381);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void RDsi_CheckedChanged(object sender, EventArgs e)
        {
            if (RDsi.Checked == true)
            {
                DataTable d = DB.recuperar("USUARIOS", "USUARIO", $"NAME_PC = '{Dns.GetHostName()}'");
                if (d.Rows.Count > 0)
                {
                    CBusuario.Visible = true;
                    CBusuario.DataSource = d;
                    CBusuario.DisplayMember = "USUARIO";
                    RDno.Checked = false;
                }
            }
        }

        private void tEMATICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mecanografia.DESAFIOS.FrmTematicasV tema = new mecanografia.DESAFIOS.FrmTematicasV();
            this.AddOwnedForm(tema);
            tema.ShowDialog();
        }

        private void OPTdificultades_Click(object sender, EventArgs e)
        {
            mecanografia.DESAFIOS.FrmDificultades difi = new mecanografia.DESAFIOS.FrmDificultades();
            this.AddOwnedForm(difi);
            difi.ShowDialog();
        }

        private void rECORDSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mecanografia.RECORS_USUARIOS.RECORDS r = new mecanografia.RECORS_USUARIOS.RECORDS();
            this.AddOwnedForm(r);
            r.ShowDialog();
        }

        private void OPTrecordsdifi_Click(object sender, EventArgs e)
        {
            mecanografia.RECORS_USUARIOS.FrmRecordsDificultades rd = new mecanografia.RECORS_USUARIOS.FrmRecordsDificultades();
            this.AddOwnedForm(rd);
            rd.ShowDialog();
        }

        private void rECORDSTEMATICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mecanografia.RECORS_USUARIOS.FrmRecordsTematicas rtema = new mecanografia.RECORS_USUARIOS.FrmRecordsTematicas();
            this.AddOwnedForm(rtema);
            rtema.ShowDialog();
        }

        private void RDno_CheckedChanged(object sender, EventArgs e)
        {
            if (RDno.Checked == true)
            {
                CBusuario.Visible = false;
                RDsi.Checked = false;
            }
        }

        private void OPTLogoSAEG_Click(object sender, EventArgs e)
        {
            h.Info("Este proyecto es de Mecanografia con el objetivo de escribir la maxima cantidad de palabras y que estas sean correctas");
        }

        private void rECORDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mecanografia.RECORS_USUARIOS.RECORDS rec = new mecanografia.RECORS_USUARIOS.RECORDS();
            this.AddOwnedForm(rec);
            rec.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambiarmodos();
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            MenuOpciones.Enabled = false;
            lblSEGUNDOS.Text = "60";
            btnreiniciar.Enabled = false;
            txtpalabrasescritas.Enabled = true;
            txtpalabrasescritas.Focus();
            RELOJ.Start();
            txtpalabrasescritas.Clear();
            correctas = 0; incorrectas = 0; pcompletadas = 0; L_omitidas = 0; L_PosM = 0; L_added = 0;
            lista_palabras();
            lblINCIAR_SESION.Enabled = false;
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
    }
}
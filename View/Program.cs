using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;
namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ControllerGuia.InicializarGuias();
            
            //jEFE
            ControllerJefeMuseo.InicializarJefes();
            //Relaciones publicas
            ControllerRelacionesPublicas.InicializarRelacionesPublicas();
            //LOGIN Y TODO COMO ANTES
            //OBRAS 
            ControllerObraArte.InicializarObras();
            
            //Exposicones
            ControllerExposicion.InicializarExposiciones();
            
            //GALERIA
            ControllerGaleria.InicializarGalerias();

            //Insumos
            ControllerInsumo.InicializarInsumo();

            //Tour
            ControllerTour.InicializarTour();
            bool continuar = false;
            while (!continuar)
            {
                string tipoUser = LoginUsuario();
                Console.WriteLine(tipoUser);
                if (tipoUser == "Jefe")
                {
                    int opcion;
                    do
                    {
                        opcion = MenuJefes();
                        switch (opcion)
                        {
                            case 1:
                                AsignarGuia();
                                break;
                            case 2:
                                VerTourEscolar(ControllerTour.ObtenerListadoTours());
                                break;
                            case 3:
                                continuar = false;
                                break;
                            case 0:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opcion Invalida");
                                break;
                        }
                    } while (opcion != 0);

                }
                else if (tipoUser == "Guia")
                {
                    int opcion;
                    do
                    {
                        opcion = MenuGuia();
                        switch (opcion)
                        {
                            case 1:
                                RealizarTour();
                                break;
                            case 2:
                                AgregarInsumos();
                                break;
                            case 3:
                                VerTourEscolar(ControllerTour.ObtenerListadoTours());
                                break;
                            case 4:
                                opcion = 0;
                                break;
                            case 0:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opcion Invalida");
                                break;
                        }
                    } while (opcion != 0);
                }
                else if (tipoUser == "RP")
                {
                    int opcion;
                    do
                    {
                        opcion = MenuRelacionesPublicas();
                        switch (opcion)
                        {
                            case 1:
                                VerDisponibilidadTour();
                                break;
                            case 2:
                                VerTourEscolar(ControllerTour.ObtenerListadoTours());
                                break;
                            case 3:
                                opcion = 0;
                                break;
                            case 0:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opcion Invalida");
                                break;
                        }
                    } while (opcion != 0);
                }
                Console.ReadLine();
            }
        
    }

        static void VerListadoGuias(List<Guia> listadoGuias)
        {
            Console.WriteLine("--- LISTADO DE GUÍAS ---");
            foreach (var guia in listadoGuias)
            {
                Console.WriteLine($"Id:{guia.Id}");
                Console.WriteLine($"Usuario: {guia.Usuario}");
                Console.WriteLine($"Nombre: {guia.Nombre} {guia.Apellido}");
                Console.WriteLine();
            }
        }
        static String LoginUsuario()
        {

            //------------------- INICIO DE SESIÓN -------------------//
            Console.WriteLine("Ingrese su usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña: ");
            string contrasena = Console.ReadLine();

            foreach (JefeMuseo jefe in ControllerJefeMuseo.ObtenerJefesMuseo())
            {
                if (jefe.Usuario == usuario && jefe.Password == contrasena)
                {
                    return "Jefe";
                }
            }

            foreach (Guia guia in ControllerGuia.ObtenerGuias())
            {
                if (guia.Usuario == usuario && guia.Password == contrasena)
                {
                    return "Guia";
                }
            }
            foreach (RelacionPublica rp in ControllerRelacionesPublicas.ObtenerRp())
            {
                if (rp.Usuario == usuario && rp.Password == contrasena)
                {
                    return "RP";
                }
            }
            return "incorrecto";
        }
        static int MenuJefes()
        {
            int opcion;
            Console.WriteLine("-- Menú Jefe Museo --");
            Console.WriteLine("[1] Asignar Guia");
            Console.WriteLine("[2] Ver listado de Tour");
            Console.WriteLine("[3] Ver listado de Insumos");
            Console.WriteLine("[4] Cerrar Sesión");
            Console.WriteLine("[0] Salir");
            do
            {
                Console.WriteLine("Selecciona una opción: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out opcion))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Por favor, ingrese solo números.");
                }
            } while (true);
            return opcion;
        }

        static int MenuGuia()
        {
            int opcion;
            Console.WriteLine("-- Menú Guia --");
            Console.WriteLine("[1] Realizar Tour");
            Console.WriteLine("[2] Preparar Insumos");
            Console.WriteLine("[3] Ver listado de Tour");
            Console.WriteLine("[4] Cerrar Sesion");
            Console.WriteLine("[0] Salir");
            do
            {
                Console.WriteLine("Selecciona una opción: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out opcion))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Por favor, ingrese solo números.");
                }
            } while (true);
            return opcion;
        }
        static int MenuRelacionesPublicas()
        {
            int opcion;
            Console.WriteLine("-- Menú Relaciones Publicas --");
            Console.WriteLine("[1] Ver Disponibilidad");
            Console.WriteLine("[2] Ver listado de Insumos");
            Console.WriteLine("[3] Cerrar Sesion");
            Console.WriteLine("[0] Salir");
            do
            {
                Console.WriteLine("Selecciona una opción: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out opcion))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Por favor, ingrese solo números.");
                }
            } while (true);
            return opcion;
        }

        static void VerListadoObras(List<ObraArte> listadoObras)
        {

            Console.WriteLine("--- LISTADO DE OBRAS DE ARTE ---");
            foreach (var obra in listadoObras)
            {
                Console.WriteLine($"--- ID: {obra.Id} | {obra.Nombre}");
                Console.WriteLine($"--- Autor: {obra.Autor} | Fecha: {obra.Fecha}");
                Console.WriteLine($"--- Descripción: {obra.Descripcion}");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------");
        }

        static void AsignarGuia()
        {
            List<Tour> listadoDeTours = ControllerTour.ObtenerListadoTours().Where(tour => tour.Estado == "VERIFICADO").ToList();
            if (!listadoDeTours.Any())
            {
                Console.WriteLine("--No hay datos para Mostrar--");
            }
            else
            {
                VerTourEscolar(listadoDeTours);
                Console.WriteLine("--------------------------");
                Console.WriteLine("Seleccione Tour por ID:");
                int idTour = Convert.ToInt32(Console.ReadLine());
                VerListadoGuias(ControllerGuia.ObtenerGuias());
                bool estado = false;
                int cantidadGuias = 0;
                List<Guia> guias = new List<Guia>();
                do
                {
                    if (cantidadGuias >= 3)
                    {
                        Console.WriteLine("---NO SE ACEPTAN MAS GUIAS---");
                        estado = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese Id del Guia");
                        int idBuscado = Convert.ToInt32(Console.ReadLine());
                        Guia guiaEncontrado = ControllerGuia.ObtenerGuias().Find(guia => guia.Id == idBuscado);
                        if (guiaEncontrado == null)
                        {
                            Console.WriteLine("No se Encontro el Guia");
                            estado = true;
                        }
                        else
                        {
                            ControllerTour.CambiarEstadoTour(idTour,"ASIGNADO");
                            guias.Add(guiaEncontrado);
                            Console.WriteLine("----GUIA AGREGADO CORRECTAMENTE----");
                            bool creado = ControllerTour.AgregarGuia(idTour, guias);
                            cantidadGuias += 1;
                            Console.WriteLine("¿Desea agregar mas guias? [s] SI - [n] NO");
                            String opcion = Console.ReadLine();
                            if (opcion == "s")
                            {
                                estado = false;
                            }
                            else if (opcion == "n")
                            {
                                estado = true;
                            }
                            else
                            {
                                Console.WriteLine("Opcion no Validad");
                                estado = true;
                            }
                        }
                    }
                } while (!estado);
            }
        }
        static void VerTourEscolar(List<Tour> tours)
        {
            foreach (Tour item in (tours))
            {
                Console.WriteLine($"------TOURS---{item.Estado}----------");
                Console.WriteLine($"---ID:{item.Id} | Exposicion:{item.NombreExpo}");
                Console.WriteLine($"---Fecha:{item.Fecha} {item.Hora}");
                Console.WriteLine();
                Console.WriteLine("Listado de obras dentro del Tour:") ;
                VerListadoObras(item.ListadoObrasTour);
                Console.WriteLine("Listado de obras Guias  dentro del  Tour:");
                VerListadoGuias(item.ListadoGuias);
                Console.WriteLine("Insumos dentro del tour dentro del  Tour:");
                VerInsumos(item.ListadoInsumos);
                Console.WriteLine();
            }























        }
        static void VerInsumos(List<Insumo> listadoInsumo)
        {
            foreach (var item in listadoInsumo)
            {
                Console.WriteLine($"Id:{item.Id} | Nombre: {item.Nombre} |  Cantidad: {item.CantidadRequerida}");
                Console.WriteLine();
            }
        }

        static void VerDisponibilidadTour()
        {
            List<Tour> listadoDeTour = ControllerTour.ObtenerListadoTours().Where(tour => tour.Estado == "SOLICITADO").ToList();
            if (!listadoDeTour.Any())
            {
                Console.WriteLine("--No hay datos para Mostrar--");
            }
            else
            {
                VerTourEscolar(listadoDeTour);
                Console.WriteLine("--------------------------");
                Console.WriteLine("Seleccione una Id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Desea confirmar datos del Tour [s] SI - [n] NO");
                String opcion = Console.ReadLine();
                if (opcion == "s")
                {
                    ControllerTour.CambiarEstadoTour(id, "VERIFICADO");
                    Console.WriteLine("-----TOUR VERIFICADO CORRECTAMENTE-----");
                }
                else if (opcion == "n")
                {
                    Console.WriteLine("-----No se realizo ningun Cambio-----");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
        }

        static void AgregarInsumos()
        {
            List<Insumo> listadoInsumo = new List<Insumo>();
            VerTourEscolar(ControllerTour.ObtenerListadoTours().Where(tour => tour.Estado == "ASIGNADO").ToList());
            Console.WriteLine("Seleccione Tour por ID:");
            int idTour = int.Parse(Console.ReadLine());
            VerInsumos(ControllerInsumo.ObterneInsumos());
            Console.WriteLine("SELECCIONE EL ID DEL INSUMO");
            int idInsumo = int.Parse(Console.ReadLine());
            Insumo insumoS = ControllerInsumo.ObterneInsumos().Find(insumo => insumo.Id == idInsumo);
            Console.WriteLine("inserte cantidad de insumos");
            int cantidadInsumo = int.Parse(Console.ReadLine());
            if (cantidadInsumo> insumoS.CantidadRequerida)
            {
                Console.WriteLine("CANTIDAD MAYOR A LA REQUERIDA");

            }else if (cantidadInsumo < 0)
            {

                Console.WriteLine("CANTIDAD no puede ser menor a 0");


            }
            else
            {
                insumoS.CantidadRequerida = cantidadInsumo;
                listadoInsumo.Add(insumoS);
                Console.WriteLine("------INSUMO AGREGADO CORRECTAMENTE----");
                bool creado = ControllerTour.AgregarInsumotour (idTour, listadoInsumo, "PREPARADO");
            }

        }

        static void RealizarTour()
        {
            List<Tour> listadoDeTour = ControllerTour.ObtenerListadoTours().Where(tour => tour.Estado == "PREPARADO").ToList();
            if (!listadoDeTour.Any())
            {
                Console.WriteLine("No hay Tour Preparado");

            }
            else
            {
                VerTourEscolar(listadoDeTour);
                Console.WriteLine("Seleccione Id de tour");
                int idTour = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Deseas realizar tour? [s] SI - [n] NO");
                String opcion = Console.ReadLine();
                if (opcion == "s")
                {
                    ControllerTour.CambiarEstadoTour(idTour, "REALIZADO");
                }
                else if (opcion == "n")
                {
                    Console.WriteLine("NO SE REALIZÓ TOUR");
                        
                }
                else
                {
                    Console.WriteLine("Opcion no valida");

                }


            }
        }


    }
}

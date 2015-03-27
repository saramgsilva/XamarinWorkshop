

using System;
using System.Collections.ObjectModel;
using ENEI.SessionsApp.Model;

namespace ENEI.SessionsApp.Data
{
    public static class SessionsDataSource
    {
        public static ObservableCollection<Session> GetSessions()
        {
            var sessions = new ObservableCollection<Session>
            {
               
                new Session
                {
                    Name = "A atratividade dos cursos de engenharia em Portugal",
                    Description = @"Esta sessão de reflexão pretende contribuir para a análise da situação atual, principalmente a nível nacional mas também a nível internacional, em que se verifica uma grande dificuldade em atrair estudantes para (pelo menos para alguns) cursos de engenharia e para a apresentação de soluções para a resolução deste problema que envolvam as instituições de ensino superior, universitário e politécnico, os estudantes e as escolas do ensino básico e secundário, as famílias e a sociedade em geral.
Esta sessão promovida pela Ordem dos Engenheiros conta com a participação do Prof. José Carlos Marques dos Santos (UP), do Prof. Armando Pires (IPS), do Prof. António Dias de Figueiredo (UC) e do Prof. Fernando Seabra Santos (UC), bem como da presença do Sr. Vice-Reitor, Prof. Luís Filipe Menezes, em representação do Sr. Reitor da UC e do Sr. Secretário de Estado do Ensino Superior, Prof. José Ferreira Gomes. O Prof. José Carlos Quadrado (ISEP e Presidente da Assembleia Geral da SPEE) será o moderador da sessão.",
                    Date = "30/03/15",
                    Schedule="10:00 - 11:00",
                    Room ="N/D",
                    Speaker = new Speaker
                    {
                        Name = "Ordem de Engenheiros",
                        ImageUrl = "http://s20.postimg.org/s8qxsubq5/engenheiros.gif"
                    }
                },
                new Session
                {
                    Name = "Meteor.js",
                    Description = @"O Meteor é uma plataforma para criação de aplicações web com HTML, CSS e JavaScript. Neste workshop será feita uma descrição da plataforma, os básicos da sua funcionalidade e demonstrados alguns conceitos de reatividade com a mesma. Apenas conhecimento dos básicos de HTML e JavaScript serão necessários para o workshop.",
                    Date = "28/03/15",
                    Schedule="11:30 - 13:00",
                    Room ="C52",
                    Speaker = new Speaker
                    {
                        Name = "David Gomes",
                        ImageUrl = "http://s20.postimg.org/w1ag8kr8d/david_gomes.png"
                    }
                }
                ,
                 new Session
                {
                    Name = "Xamarin Workshop",
                    Description = @"In this Xamarin Workshop, you will learn what’s Xamarin and its products, how to create cross-platform application, using Xamarin, for Android and IOS. You will learn the two patterns most used in this kind of applications and at the end you will have or own ENEI Sessions App .
                    Initial presentation:
                    Xamarin Overview
                    What’s Xamarin?
                    Xamarin Platform & Xamarin APIs
                    Other Products: Test Cloud, Xamarin Insights and Xamarin University
                    Cross-platform development using Xamarin
                    What’s cross-platform development
                    MVVM Pattern
                    Abstraction Pattern
                    Xamarin Forms
                    After the initial presentation, let’s code:  ENEI Sessions App
                    Let’s code:  ENEI Sessions App
                    Create new Xamarin Forms project in Xamarin Studio;
                    Create the main page with a menu (Create, Edit, Delete, Share options)
                    Create the UI for the main page to show a list of Sessions (including template for Listview item)
                    Create the UI for the Create/Edit Session
                    Delete Session
                    Create the Share “Session”
                    More information: http://saramgsilva.github.io/XamarinWorkshop/",
                    Date = "28/03/15",
                    Schedule="14:00 - 16:00",
                    Room ="C51",
                    Speaker = new Speaker
                    {
                        Name = "João Matos",
                        ImageUrl = "http://s20.postimg.org/ozcimdnml/joao_matos.png"
                    }
                },
                 new Session
                {
                    Name = "Xamarin Workshop",
                    Description = @"In this Xamarin Workshop, you will learn what’s Xamarin and its products, how to create cross-platform application, using Xamarin, for Android and IOS. You will learn the two patterns most used in this kind of applications and at the end you will have or own ENEI Sessions App .
                    Initial presentation:
                    Xamarin Overview
                    What’s Xamarin?
                    Xamarin Platform & Xamarin APIs
                    Other Products: Test Cloud, Xamarin Insights and Xamarin University
                    Cross-platform development using Xamarin
                    What’s cross-platform development
                    MVVM Pattern
                    Abstraction Pattern
                    Xamarin Forms
                    After the initial presentation, let’s code:  ENEI Sessions App
                    Let’s code:  ENEI Sessions App
                    Create new Xamarin Forms project in Xamarin Studio;
                    Create the main page with a menu (Create, Edit, Delete, Share options)
                    Create the UI for the main page to show a list of Sessions (including template for Listview item)
                    Create the UI for the Create/Edit Session
                    Delete Session
                    Create the Share “Session”
                    More information: http://saramgsilva.github.io/XamarinWorkshop/",
                    Date = "28/03/15",
                    Schedule="14:00 - 16:00",
                    Room ="C51",
                    Speaker = new Speaker
                    {
                        Name = "Sara Silva",
                        ImageUrl = "http://s20.postimg.org/zeiovakt9/sara_silva.png"
                    }
                },
                 new Session
                {
                    Name = "Unity 3D",
                    Description = @"N/D",
                    Date = "29/03/15",
                    Schedule="N/D",
                    Room ="N/D",
                    Speaker = new Speaker
                    {
                        Name = "Eduardo Matos",
                        ImageUrl = "http://s20.postimg.org/4ycrx5za5/eduardo_matos.png"
                    }
                }
                , new Session
                {
                    Name = "A Essência dos UAV/Drones",
                    Description = @"Durante 60 minutos fique a conhecer melhor o que está por detrás de um drone, o hardware e software envolvidos e como construir o seu próprio drone. Qual o futuro da utilização comercial/civil destes veículos não tripulado.
Após o workshop haverá uma sessão de voo de cerca de 5/10min com o drone construído no workshop.",
                    Date = "30/03/15",
                    Schedule="10:00 — 12:00",
                    Room ="N/D",
                    Speaker = new Speaker
                    {
                        Name = "Miguel Almeida",
                        ImageUrl = "http://s20.postimg.org/tcb24swd9/miguel_almeida.png"
                    }
                },
                 new Session
                {
                    Name = "Arduino",
                    Description = @"N/D",
                    Date = "28/03/15",
                    Schedule="15:00 - 17:00",
                    Room ="N/D",
                    Speaker = new Speaker
                    {
                        Name = "N/D",
                        ImageUrl = "http://s20.postimg.org/re4e6t3vd/ic_action_user.png"
                    }
                },
                 new Session
                {
                    Name = "A Anita vai ao ENEI aprender a criar jogos",
                    Description = @"Vives para jogos? Queres interagir com profissionais?
Vem criar um jogo connosco. Vamos propor um desafio em relação a game development e vamos-nos divertir a resolvê-lo em grupo.
Tecnologia? Nível de conhecimentos?
Não te preocupes! Podes usar o que quiseres. Será algo que qualquer pessoa consegue fazer mas ao mesmo tempo qualquer pessoa consegue apreciar.
No fim, esperamos fazer amizades e mostrar que para se fazer jogos só é preciso experimentar.",
                    Date = "28/03/20015",
                    Schedule="11:00 - 13:00",
                    Room ="N/D",
                    Speaker = new Speaker
                    {
                        Name = "Gilberto Medeiros",
                        ImageUrl = "http://s20.postimg.org/re4e6t3vd/ic_action_user.png"
                    }
                }
            };

            return sessions;
        }
    }
}

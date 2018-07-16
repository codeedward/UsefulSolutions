using System.Collections.Generic;
using System.Web.Mvc;
using VeePrototype.Models;

namespace VeePrototype.Controllers
{
    public class VeeController : Controller
    {
        private static int _counter = 1;
        // GET: Vee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            var model = new IndexViewModel()
            {
                Collections = new List<CollectionOfPages>()
                {
                    new CollectionOfPages()
                    {
                        IsSelected = true,
                        Id = 1,
                        Title = "Collection 1",
                        Pages = new List<Page>()
                        {
                            new Page()
                            {
                                Title = "Main information",
                                Sections = new List<Section>()
                                {
                                    new Section()
                                    {
                                        Title = "Personal details",
                                        Questions = new List<Question>()
                                        {
                                            new Question(_counter++, true, "First name", QuestionType.Text),
                                            new Question(_counter++, true, "Last name", QuestionType.Text),
                                            new Question(_counter++, false, "Initials", QuestionType.Text)
                                        }
                                    },
                                    new Section()
                                    {
                                        Title = "Extra information",
                                        Questions = new List<Question>()
                                        {
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, true, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                        }
                                    }
                                }
                            },
                            new Page()
                            {
                                Title = "Main information123",
                                Sections = new List<Section>()
                                {
                                    new Section()
                                    {
                                        Title = "Personal details123",
                                        Questions = new List<Question>()
                                        {
                                            new Question(_counter++, true, "First name", QuestionType.Text),
                                            new Question(_counter++, true, "Last name", QuestionType.Text),
                                            new Question(_counter++, false, "Initials", QuestionType.Text)
                                        }
                                    },
                                    new Section()
                                    {
                                        Title = "Extra information123",
                                        Questions = new List<Question>()
                                        {
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, true, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new CollectionOfPages()
                    {
                        Id = 2,
                        Title = "Collection 2",
                        Pages = new List<Page>()
                        {
                            new Page()
                            {
                                Title = "Extra information 1",
                                Sections = new List<Section>()
                                {
                                    new Section()
                                    {
                                        Title = "Test",
                                        Questions = new List<Question>()
                                        {
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text),
                                            new Question(_counter++, false, "Some question" + _counter, QuestionType.Text)
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new CollectionOfPages()
                    {
                        Id = 3,
                        Title = "Collection 3",
                        Pages = new List<Page>()
                        {
                           new Page()
                           {
                               Title = "Extra information 2",
                               Sections = new List<Section>()
                               {
                                   new Section()
                                   {
                                       Questions = new List<Question>()
                                       {
                                           new Question(_counter++, false, "Some question", QuestionType.Text)
                                       }
                                   }
                               }
                           }
                        }
                    }
                }
            };

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
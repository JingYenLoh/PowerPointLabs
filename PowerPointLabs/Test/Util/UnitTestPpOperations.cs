﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestInterface;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using PowerPointLabs.FunctionalTestInterface.Impl;
using Shape = Microsoft.Office.Interop.PowerPoint.Shape;
using ShapeRange = Microsoft.Office.Interop.PowerPoint.ShapeRange;

namespace Test.Util
{
    class UnitTestPpOperations : IPowerPointOperations
    {
        public Presentation Pres { get; set; }

        public Application App { get; set; }

        private Slide _currentSlide;

        private ShapeRange _currentShape;

        public UnitTestPpOperations(Presentation pres, Application app)
        {
            Pres = pres;
            App = app;
        }

        public void MaximizeWindow()
        {
            throw new NotImplementedException();
        }

        public void EnterFunctionalTest()
        {
            throw new NotImplementedException();
        }

        public void ExitFunctionalTest()
        {
            throw new NotImplementedException();
        }

        public bool IsInFunctionalTest()
        {
            throw new NotImplementedException();
        }

        public List<ISlideData> FetchPresentationData(string pathToPresentation)
        {
            var presentation = App.Presentations.Open(pathToPresentation, WithWindow: MsoTriState.msoFalse);
            var slideData = presentation.Slides.Cast<Slide>().Select(SlideData.FromSlide).ToList();
            presentation.Close();
            return slideData;
        }

        public List<ISlideData> FetchCurrentPresentationData()
        {
            var slideData = Pres.Slides.Cast<Slide>().Select(SlideData.FromSlide).ToList();
            return slideData;
        }

        public void SavePresentationAs(string presName)
        {
            Pres.SaveCopyAs(presName);
        }

        public void ClosePresentation()
        {
            Pres.Close();
        }

        public void ActivatePresentation()
        {
            throw new NotImplementedException();
        }

        public int PointsToScreenPixelsX(float x)
        {
            throw new NotImplementedException();
        }

        public int PointsToScreenPixelsY(float y)
        {
            throw new NotImplementedException();
        }

        public bool IsOffice2010()
        {
            throw new NotImplementedException();
        }

        public bool IsOffice2013()
        {
            throw new NotImplementedException();
        }

        public Slide GetCurrentSlide()
        {
            return _currentSlide;
        }

        public Slide SelectSlide(int index)
        {
            var slide = Pres.Slides[index];
            _currentSlide = slide;
            return slide;
        }

        public Slide SelectSlide(string slideName)
        {
            foreach (Slide slide in Pres.Slides)
            {
                if (slide.Name == slideName)
                {
                    _currentSlide = slide;
                    return slide;
                }
            }
            return null;
        }

        public Slide[] GetAllSlides()
        {
            return Pres.Slides.Cast<Slide>().ToArray();
        }

        public Selection GetCurrentSelection()
        {
            throw new NotImplementedException();
        }

        public ShapeRange SelectShape(string shapeName)
        {
            if (_currentSlide == null) return null;

            var nameList = new List<string>();
            nameList.Add(shapeName);
            _currentShape = _currentSlide.Shapes.Range(nameList.ToArray());
            return _currentShape;
        }

        public ShapeRange SelectShapes(IEnumerable<string> shapeNames)
        {
            if (_currentSlide == null) return null;
            _currentShape = _currentSlide.Shapes.Range(shapeNames.ToArray());
            return _currentShape;
        }

        public ShapeRange SelectShapesByPrefix(string prefix)
        {
            if (_currentSlide == null) return null;

            var nameList = new List<string>();
            foreach (Shape shape in _currentSlide.Shapes)
            {
                if (shape.Name.StartsWith(prefix))
                {
                    nameList.Add(shape.Name);
                }
            }
            _currentShape = _currentSlide.Shapes.Range(nameList.ToArray());
            return _currentShape;
        }

        public Shape RecursiveGetShapeWithPrefix(params string[] prefixes)
        {
            var parentShape = SelectShapesByPrefix(prefixes[0])[1];
            for (int i = 1; i < prefixes.Length; ++i)
            {
                parentShape = parentShape.GroupItems.Cast<Shape>().FirstOrDefault(shape => shape.Name.StartsWith(prefixes[i]));
            }
            return parentShape;
        }

        public FileInfo ExportSelectedShapes()
        {
            var shapes = _currentShape;
            var hashCode = DateTime.Now.GetHashCode();
            var pathName = Path.GetTempPath() + "shapeName" + hashCode;
            shapes.Export(pathName, PpShapeFormat.ppShapeFormatPNG);
            return new FileInfo(pathName);
        }

        public string SelectAllTextInShape(string shapeName)
        {
            var shape = _currentSlide.Shapes.Cast<Shape>().FirstOrDefault(sh => sh.Name == shapeName);
            var textRange = shape.TextFrame2.TextRange;
            textRange.Select();
            return textRange.Text;
        }

        public string SelectTextInShape(string shapeName, int startIndex, int endIndex)
        {
            var shape = _currentSlide.Shapes.Cast<Shape>().FirstOrDefault(sh => sh.Name == shapeName);
            var textRange = shape.TextFrame2.TextRange.Characters[startIndex, endIndex - startIndex];
            textRange.Select();
            return textRange.Text;
        }

        public void RenameSection(int index, string newName)
        {
            Pres.SectionProperties.Rename(index, newName);
        }

        public void AddSection(int index, string sectionName)
        {
            Pres.SectionProperties.AddSection(index, sectionName);
        }

        public void DeleteSection(int index, bool deleteSlides)
        {
            Pres.SectionProperties.Delete(index, deleteSlides);
        }
    }
}
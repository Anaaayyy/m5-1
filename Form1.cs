using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace m5_1
{
    public partial class Form1 : Form
    {
        private enum ShapeType { Line, Circle, Square }
        private ShapeType currentShape = ShapeType.Line; // Текущая фигура по умолчанию
        private bool isDrawing = false;
        private Point startPoint;
        private Color currentColor = Color.Black; // Цвет рисования

        // Список для хранения нарисованных фигур
        private List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas(); // Инициализация панели для рисования

            // Подписка на события кнопок
            btnLine.Click += (s, e) => SetCurrentShape(ShapeType.Line);
            btnCircle.Click += (s, e) => SetCurrentShape(ShapeType.Circle);
            btnSquare.Click += (s, e) => SetCurrentShape(ShapeType.Square);
            btnClear.Click += (s, e) => ClearCanvas();
        }

        private void InitializeCanvas()
        {
            canvas.BackColor = Color.White; // Цвет фона
            canvas.Dock = DockStyle.Fill; // Заполнение формы
            this.Controls.Add(canvas);
            canvas.MouseDown += Canvas_MouseDown;
            canvas.MouseMove += Canvas_MouseMove;
            canvas.MouseUp += Canvas_MouseUp;
            canvas.Paint += Canvas_Paint; // Подписка на событие перерисовки
        }

        private void SetCurrentShape(ShapeType shape)
        {
            currentShape = shape;
        }

        private void ClearCanvas()
        {
            shapes.Clear(); // Очистка списка фигур
            canvas.Invalidate(); // Перерисовка холста
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                canvas.Invalidate(); // Перерисовка холста
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                Shape newShape = CreateShape(startPoint, e.Location);
                if (newShape != null)
                {
                    shapes.Add(newShape); // Добавление новой фигуры в список
                }
                canvas.Invalidate(); // Перерисовка холста
            }
        }

        private Shape CreateShape(Point start, Point end)
        {
            return currentShape switch
            {
                ShapeType.Line => new Line(start, end, currentColor),
                ShapeType.Circle => new Circle(start, end, currentColor),
                ShapeType.Square => new Square(start, end, currentColor),
                _ => null
            };
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // Перерисовка всех фигур
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
    }

    // Базовый класс для фигур
    public abstract class Shape
    {
        protected Color color;

        protected Shape(Color color)
        {
            this.color = color;
        }

        public abstract void Draw(Graphics g);
    }

    // Класс для линий
    public class Line : Shape
    {
        private Point start;
        private Point end;

        public Line(Point start, Point end, Color color) : base(color)
        {
            this.start = start;
            this.end = end;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                g.DrawLine(pen, start, end);
            }
        }
    }

    // Класс для кругов
    public class Circle : Shape
    {
        private Point center;
        private int radius;

        public Circle(Point start, Point end, Color color) : base(color)
        {
            center = start;
            radius = (int)Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                g.DrawEllipse(pen, center.X - radius, center.Y - radius, radius * 2, radius * 2);
            }
        }
    }

    // Класс для квадратов
    public class Square : Shape
    {
        private Point topLeft;
        private int side;

        public Square(Point start, Point end, Color color) : base(color)
        {
            topLeft = start;
            side = Math.Abs(end.X - start.X);
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                g.DrawRectangle(pen, topLeft.X, topLeft.Y, side, side);
            }
        }
    }
}

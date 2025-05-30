using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : UserControl
{
    private TextBox textBox;
    private int borderRadius = 10;
    private Color borderColor = Color.LightGray;
    private int borderSize = 1;

    public RoundedTextBox()
    {
        InitializeTextBox();
        this.Resize += RoundedTextBox_Resize;
        this.BackColor = Color.Transparent;
        this.DoubleBuffered = true;
    }

    private void InitializeTextBox()
    {
        textBox = new TextBox();
        textBox.BorderStyle = BorderStyle.None;
        textBox.BackColor = Color.White;
        textBox.Multiline = false;
        textBox.Font = new Font("Segoe UI", 12F);

        // Cách này để TextBox fill hết vùng bên trong UserControl
        textBox.Dock = DockStyle.Fill;

        // Đặt padding cho UserControl bằng borderSize để tạo khoảng cách cho viền
        this.Padding = new Padding(6);

        this.Controls.Add(textBox);
    }

    private void RoundedTextBox_Resize(object sender, EventArgs e)
    {
        this.Invalidate();
    }

    private void UpdateTextBoxSize()
    {
        if (textBox != null)
        {
            int padding = borderSize + 5; // padding từ viền + khoảng cách thêm
            textBox.Location = new Point(padding, padding);

            // Size bằng kích thước usercontrol trừ padding 2 chiều
            textBox.Size = new Size(
                this.ClientSize.Width - padding * 2,
                this.ClientSize.Height - padding * 2
            );
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = this.ClientRectangle;
        rect.Width -= 1;
        rect.Height -= 1;

        using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
        {
            // Vẽ nền trắng bên trong
            using (SolidBrush brush = new SolidBrush(textBox.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Vẽ viền
            using (Pen pen = new Pen(borderColor, borderSize))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;

        Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

        // Top-left
        path.AddArc(arcRect, 180, 90);

        // Top-right
        arcRect.X = rect.Right - diameter;
        path.AddArc(arcRect, 270, 90);

        // Bottom-right
        arcRect.Y = rect.Bottom - diameter;
        path.AddArc(arcRect, 0, 90);

        // Bottom-left
        arcRect.X = rect.Left;
        path.AddArc(arcRect, 90, 90);

        path.CloseFigure();
        return path;
    }

    // Override Dispose đúng chuẩn
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (textBox != null)
            {
                textBox.Dispose();
                textBox = null;
            }
        }
        base.Dispose(disposing);
    }

    // Properties cho người dùng set/get

    public override string Text
    {
        get => textBox?.Text ?? "";
        set
        {
            if (textBox != null)
            {
                textBox.Text = value;
            }
        }
    }

    public int BorderRadius
    {
        get => borderRadius;
        set
        {
            if (value >= 0)
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
    }

    public Color BorderColor
    {
        get => borderColor;
        set
        {
            borderColor = value;
            this.Invalidate();
        }
    }

    public int BorderSize
    {
        get => borderSize;
        set
        {
            if (value >= 1)
            {
                borderSize = value;
                UpdateTextBoxSize();
                this.Invalidate();
            }
        }
    }
    public override Font Font
    {
        get => textBox.Font;
        set
        {
            textBox.Font = value;
            base.Font = value;
            UpdateTextBoxSize();
        }
    }
    public HorizontalAlignment TextAlign
    {
        get => textBox.TextAlign;
        set => textBox.TextAlign = value;
    }

    public override Color ForeColor
    {
        get => textBox.ForeColor;
        set => textBox.ForeColor = Color.Black;
    }

    public override Color BackColor
    {
        get => textBox.BackColor;
        set
        {
            textBox.BackColor = Color.White;
            Invalidate();
        }
    }

    public TextBox InnerTextBox => textBox;  // Truy cập TextBox bên trong nếu cần
}

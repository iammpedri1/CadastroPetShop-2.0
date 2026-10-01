using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GroupBoxRedondo : GroupBox
{
    // Propriedade para controlar o tamanho do arredondamento (raio dos cantos)
    public int RaioDoCanto { get; set; } = 15;

    // Propriedade para mudar a cor da borda se desejar
    public Color CorDaBorda { get; set; } = Color.LightGray;

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias; // Remove o efeito serrilhado

        // Define a área total da borda (descontando o texto do topo)
        Size tamanhoTexto = TextRenderer.MeasureText(this.Text, this.Font);
        Rectangle retanguloBorda = new Rectangle(0, tamanhoTexto.Height / 2, this.Width - 1, this.Height - (tamanhoTexto.Height / 2) - 1);

        // Limpa o fundo antigo
        g.Clear(this.BackColor);

        // Cria o caminho com os cantos arredondados
        using (GraphicsPath caminho = ObterCaminhoArredondado(retanguloBorda, RaioDoCanto))
        {
            // Desenha o fundo interno do GroupBox
            using (SolidBrush pincelFundo = new SolidBrush(this.BackColor))
            {
                g.FillPath(pincelFundo, caminho);
            }

            // Desenha a linha da borda arredondada
            using (Pen canetaBorda = new Pen(CorDaBorda, 1))
            {
                g.DrawPath(canetaBorda, caminho);
            }
        }

        // Desenha o texto do título do GroupBox por cima se ele existir
        if (!string.IsNullOrEmpty(this.Text))
        {
            using (SolidBrush pincelTexto = new SolidBrush(this.ForeColor))
            {
                // Deixa um pequeno espaçamento nas laterais do texto
                g.DrawString(this.Text, this.Font, pincelTexto, 10, 0);
            }
        }
    }

    // Função matemática auxiliar para arredondar os cantos do retângulo
    private GraphicsPath ObterCaminhoArredondado(Rectangle bounds, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;

        // Canto superior esquerdo
        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
        // Canto superior direito
        path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
        // Canto inferior direito
        path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y + bounds.Height - diameter, diameter, diameter, 0, 90);
        // Canto inferior esquerdo
        path.AddArc(bounds.X, bounds.Y + bounds.Height - diameter, diameter, diameter, 90, 90);

        path.CloseAllFigures();
        return path;
    }
}

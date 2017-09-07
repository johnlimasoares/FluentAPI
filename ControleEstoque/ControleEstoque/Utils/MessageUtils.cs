using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.Utils
{
    public static class MessageUtils
    {
        public static void ShowError(this string message)
        {
            MessageBox.Show(message, "Ops, ocorreu um erro ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InformeCampoObrigatorio(this string message)
        {
            MessageBox.Show($"O campo '{message}' é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowInfo(this string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowOk(this string message)
        {
            MessageBox.Show(message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowYesOrNO(this string message)
        {
            return MessageBox.Show(message, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    class reservaEventosBLL : Reservas
    {
        public reservaEventosBLL(int id, int a)
        {
            idH = id;
            from = 0;
            amount = a;
            page = 1;
            this.defaultFilterStr("");
            totalPages = 0;
        }

        public override DataTable dataHeaders()
        {
            reservaEventosDAL modelo = new reservaEventosDAL();
            return modelo.bringDataHeaders(filterStr).Tables[0];
        }
        public override DataTable recordsAmount()
        {
            reservaEventosDAL modelo = new reservaEventosDAL();
            return modelo.bringRecordsAmount(filterStr).Tables[0];
        }

        public override void acceptState(string codes)
        {
            reservaEventosDAL modelo = new reservaEventosDAL();
            modelo.acceptReservas(codes);
        }
        public override void rejectState(string codes)
        {
            reservaEventosDAL modelo = new reservaEventosDAL();
            modelo.rejectReservas(codes);
        }

        public override void defaultFilterStr(string conditions)
        {
            this.filterStr = $"WHERE eventos.id_hotel = {idH} " + conditions;
        }

        public override void defineFilterStr()
        {
            this.filterStr += $"ORDER BY id_reservaEvento OFFSET {this.from} ROWS FETCH NEXT {this.amount} ROWS ONLY";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using sistemaHoteles.DAL;

namespace sistemaHoteles.BLL
{
    class reservaHabitacionesBLL : Reservas
    {
        public reservaHabitacionesBLL(int id, int a)
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
            reservaHabitacionesDAL modelo = new reservaHabitacionesDAL();
            return modelo.bringDataHeaders(filterStr).Tables[0];
        }
        public override DataTable recordsAmount()
        {
            reservaHabitacionesDAL modelo = new reservaHabitacionesDAL();
            return modelo.bringRecordsAmount(filterStr).Tables[0];
        }
        public override void acceptState(string codes)
        {
            reservaHabitacionesDAL modelo = new reservaHabitacionesDAL();
            modelo.acceptReservas(codes);
        }
        public override void rejectState(string codes)
        {
            reservaHabitacionesDAL modelo = new reservaHabitacionesDAL();
            modelo.rejectReservas(codes);
        }

        public override void defaultFilterStr(string conditions)
        {
            this.filterStr = $"WHERE habitaciones.id_hotel = {idH} " + conditions;
        }
        public override void defineFilterStr()
        {
            this.filterStr += $"ORDER BY id_reserva OFFSET {this.from} ROWS FETCH NEXT {this.amount} ROWS ONLY";
        }
    }
}

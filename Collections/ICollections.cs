﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    interface ICollections
    {
        /// <summary>
        /// переберите этот мешок на два других мешка,
        /// в один положите испорченные, а в другой - неиспорченные. 
        /// Из самого первого мешка при этом картофелины должны уже удаляться
        /// </summary>
        /// <param name="potatoeBag">входной мешок картошки</param>
        /// <param name="goodPotatoes">мешок с хорошими картофелинами</param>
        /// <param name="badPotatoes">мешок с плохими картофелинами</param>
        /// <returns>количество хороших картофелин</returns>
        int SortPotatoes(
            List<IPotatoe> potatoeBag, 
            out List<IPotatoe> goodPotatoes,
            out List<IPotatoe> badPotatoes);

        /// <summary>
        /// Сделать логику для второй половины задачки про датчики,
        /// а именно: дано сочетание кода датчика, значения и флаг корректности данных.
        /// Для каждого вида датчика (закодированного отдельным кодом), посчитать
        /// среднее значение среди этого вида, только для корректных данных.
        /// </summary>
        /// <param name="inputData">входные данные</param>
        /// <returns>преобразованные данные</returns>
        List<IOutData> ProcessData(
            IReadOnlyList<IInData> inputData);

        /// <summary>
        /// создайте linked list, наполните его данными из input в порядке возрастания.
        /// Запрещается использовать промежуточные контейнеры и массивы.
        /// </summary>
        /// <param name="input">список из чисел</param>
        /// <returns>созданный linked list</returns>
        LinkedList<int> CreateOrderedList(IReadOnlyList<int> input);
    }
}

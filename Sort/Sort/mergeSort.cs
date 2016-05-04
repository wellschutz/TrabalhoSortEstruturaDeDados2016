﻿namespace Sort
{
    class mergeSort
    {
        public void MergeSort(int[] array, int inicio, int fim)
        {
            int meio = 0;

            if (inicio < fim)
            {
                meio = (inicio + fim) / 2;

                MergeSort(array, inicio, meio);
                MergeSort(array, meio + 1, fim);

                Merge(array, inicio, meio, fim);
            }
        }

        private void Merge(int[] array, int inicio, int meio, int fim)
        {
            int[] temp = new int[array.Length];
            int l = inicio;
            int r = fim;
            int m = meio + 1;
            int k = l;

            while (l <= meio && m <= r)
            {
                if (array[l] <= array[m])
                {
                    temp[k++] = array[l++];
                }
                else
                {
                    temp[k++] = array[m++];
                }
            }

            while (l <= meio)
            {
                temp[k++] = array[l++];
            }

            while (m <= r)
            {
                temp[k++] = array[m++];
            }

            for (int i1 = inicio; i1 <= fim; i1++)
            {
                array[i1] = temp[i1];
            }
        }
    }
}

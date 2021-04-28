using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeVentes.Services
{
    public interface IDataService<T>
    {
        /// <summary>
        /// Retourne toutes les données T
        /// </summary>
        /// <returns>Les données de type T</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Insère un objet T au service de données
        /// </summary>
        /// <param name="record"></param>
        /// <returns>True lorsque l'insertion a réussi</returns>
        bool Insert(T record);

        /// <summary>
        /// Met à jour l'objet T si celui-ci existe dans les données, 
        /// sinon il ajoutera la donnée
        /// </summary>
        /// <param name="record">Enregistrement à mettre à jour ou insérer</param>
        /// <returns>True lorsque cela fonctionne</returns>
        bool UpdateOrInsert(T record);

        /// <summary>
        /// Supprime l'objet T de la collection
        /// </summary>
        /// <param name="record">Objet à supprimer</param>
        /// <returns>True lorsque cela fonctionne</returns>
        bool Delete(T record);

        /// <summary>
        /// Enregistre les modifications dans le service
        /// </summary>
        /// <returns>True lorsque cela fonctionne</returns>
        bool Save();
    }
}

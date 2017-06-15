﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModel;

namespace Crud
{
    public class DeviceCrubOperator
    {
        private Entities entity = new Entities();

        public Boolean create(device insert_item)
        {
            try
            {
                entity.devices.Add(insert_item);
                entity.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }

        public List<device> queryAll()
        {
            try
            {
                var devices = from d in entity.devices select d;

                return devices.ToList();

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
        }

        public List<device> queryByName(string name) {
            try
            {
                var devices = from du in entity.device_user where 0 == du.user.username.CompareTo(name) select du.device;

                return devices.ToList();
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return null;
            }

        }


        public device queryById(int id)
        {
            try
            {
                Entities entity = new Entities();

                var devices = from d in entity.devices where d.id == id select d;

                return devices.AsEnumerable().First();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }

        }

        public Boolean update(device dev) {
            try
            {
                entity.SaveChanges();
                return true;    
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return false;
            }
        }


        public Boolean delete(int id) {
            try
            {
                device dev_to_del = (from d in entity.devices where d.id == id select d).First();

                entity.devices.Remove(dev_to_del);

                entity.SaveChanges();

                return true;
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return false;
            }
        }

        public Boolean delete(device dev) {
            try
            {
                return delete(dev.id);
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return false;
            }
        }

        public List<user> getAllUserOfDevice(device d) {
            try
            {
                return (from du in d.device_user select du.user).ToList();
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return null;
            }
        }

        public Boolean addUserToDevice(device d, user u) {
            try
            {
                device_user du = new device_user();

                du.device_id = d.id;
                du.user_id = u.id;

                entity.device_user.Add(du);
                entity.SaveChanges();

                return true;
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return false;
            }
        }

        public Boolean deleteUserFromDevice(device d, user u) {
            try
            {
                device_user record = (from du in d.device_user where du.device_id == d.id select du).First();

                entity.device_user.Remove(record);

                entity.SaveChanges();

                return true;
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return false;
            }
        }

        ~DeviceCrubOperator() {
            entity.Dispose();
        }
    }
}

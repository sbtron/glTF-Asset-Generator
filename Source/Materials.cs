﻿using glTFLoader.Schema;
using System.Collections.Generic;
using static AssetGenerator.GLTFWrapper;

namespace AssetGenerator
{
    [AssetGroup("Materials")]
    internal static class Materials
    {
        [Asset("TestSingleTriangle")]
        public static void TestSingleTriangle(string name, Gltf gltf, List<Data> dataList)
        {
            var geometryData = new Data(name + ".bin");
            dataList.Add(geometryData);

            Common.SingleTriangle(gltf, geometryData);

            gltf.Materials = new[]
            {
                new Material
                {
                    PbrMetallicRoughness = new MaterialPbrMetallicRoughness
                    {
                        BaseColorFactor = new[] { 1.0f, 0.0f, 0.0f, 0.0f },
                    }
                }
            };

            gltf.Meshes[0].Primitives[0].Material = 0;
        }
        [Asset("TestSingleTriangleMultipleUVSetsWrapper")]
        public static void TestSingleTriangleMultipleUVSetsWrapper(string name, Gltf gltf, List<Data> dataList)
        {
            var geometryData = new Data(name + ".bin");
            dataList.Add(geometryData);
            GLTFWrapper wrapper = Common.SingleTriangleMultipleUVSetsWrapper(gltf, geometryData);

            GLTFMaterial mat = new GLTFMaterial();
            
            mat.metallicRoughnessMaterial = new GLTFMetallicRoughnessMaterial
            {
                baseColorTexture = new GLTFTexture
                {
                    source = new GLTFImage
                    {
                        uri = "green.png"
                    },
                    sampler = new GLTFSampler(),
                    texCoordIndex = 0

                }
            };
            
           
           
            wrapper.scenes[0].meshes[0].meshPrimitives[0].material = mat;
            wrapper.buildGLTF(gltf, geometryData);
        }
        [Asset("TestSingleTriangleMultipleUVSets")]
        public static void TestSingleTriangleMultipleUVSets(string name, Gltf gltf, List<Data> dataList)
        {
            var geometryData = new Data(name + ".bin");
            dataList.Add(geometryData);
            Common.SingleTriangleMultipleUVSets(gltf, geometryData);

            gltf.Materials = new[]
             {
                new Material
                {
                    PbrMetallicRoughness = new MaterialPbrMetallicRoughness
                    {
                        BaseColorFactor = new[] { 1.0f, 1.0f, 1.0f, 0.0f },
                        BaseColorTexture = new TextureInfo
                        {
                            Index = 0,
                            TexCoord = 0
                        },
                        MetallicRoughnessTexture = new TextureInfo
                        {
                            Index = 1,
                            TexCoord = 1
                        }
                    }
                }
            };
            gltf.Images = new[]
            {
                new Image
                {
                    Uri = "green.png",
                },
                new Image
                {
                    Uri = "blue.png",
                }
            };
            gltf.Meshes[0].Primitives[0].Material = 0;
        }
        [Asset("TestSinglePlane")]
        public static void TestSinglePlane(string name, Gltf gltf, List<Data> dataList)
        {
            var geometryData = new Data(name + ".bin");
            dataList.Add(geometryData);

            Common.SinglePlane(gltf, geometryData);

            gltf.Materials = new[]
            {
                new Material
                {
                    PbrMetallicRoughness = new MaterialPbrMetallicRoughness
                    {
                        BaseColorFactor = new[] { 1.0f, 0.0f, 0.0f, 0.0f },
                    }
                }
            };

            gltf.Meshes[0].Primitives[0].Material = 0;
        }
        [Asset("TestSingleCube")]
        public static void TestSingleCross(string name, Gltf gltf, List<Data> dataList)
        {
            var geometryData = new Data(name + ".bin");
            dataList.Add(geometryData);

            Common.SingleCube(gltf, geometryData);

            gltf.Materials = new[]
            {
                new Material
                {
                    PbrMetallicRoughness = new MaterialPbrMetallicRoughness
                    {
                        BaseColorFactor = new[] { 1.0f, 0.0f, 0.0f, 0.0f },
                    }
                }
            };

            gltf.Meshes[0].Primitives[0].Material = 0;
        }
    }
}
